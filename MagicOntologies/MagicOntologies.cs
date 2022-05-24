using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace MagicOntologies
{
    public partial class MagicOntologies : Form
    {
        string ontologyPath;
        List<JToken> nodes;
        string entityName;
        string date;

        private readonly string _connStr = new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 5432,
            Database = "work_db",
            Username = "postgres",
            Password = "1"
        }.ConnectionString;

        public MagicOntologies(string ontologyPath, List<JToken> nodes, JToken str, string entityName, string date)
        {
            this.ontologyPath = ontologyPath;
            this.nodes = nodes;
            this.entityName = entityName;
            this.date = date;
            InitializeComponent();
            AddOntologyinDB();
        }
        
        private void GetReadyCMBKey(Dictionary<string, string> readyData)
        {
            if(cbKey.Items.Count == 0)
            {
                foreach (string item in readyData.Keys)
                {
                    cbKey.Items.Add(item);
                }
            }
        }

        private string GetShortName(string fullpath)
        {
            char consta = '\\';
            string fileName = "";
            for (int i = fullpath.ToString().Length - 1; i >= 0; i--)
            {
                if (!fullpath.ToString()[i].Equals(consta)) fileName += fullpath.ToString()[i];
                else break;
            }
            string name = "";
            for (int i = fileName.Length - 1; i >= 0; i--)
            {
                name += fileName[i];
            }

            return name;
        }
        
        public MagicOntologies(OntologyConfig config)
        {
            this.ontologyPath = config.ontologyPath;
            this.nodes = config.nodes;
            this.entityName = config.entityName;
            this.date = config.date;
            InitializeComponent();
            AddOntologyinDB();
            foreach (FileMetadata item in config.files)
            {
                string name = GetShortName(item.fullPath.ToString());
                ToolStripItem newitem = new ToolStripMenuItem(name, null, FileButton_Click)
                {
                    Tag = new FileMetadata(item.fullPath, item.text, null, item.entityName, item.date),
                    AutoToolTip = true,
                    ToolTipText = item.fullPath
                };
                msFiles.Items.Add(newitem);
                FileButton_Click(newitem, new EventArgs());

                ToolStripItem newitem2 = new ToolStripMenuItem(name, null, DataButton_Click)
                {
                    Tag = new FileMetadata(item.fullPath, item.text, null, item.entityName, item.date),
                    AutoToolTip = true,
                    ToolTipText = item.fullPath
                };
                msData.Items.Add(newitem2);
                DataButton_Click(newitem2, new EventArgs());

                if (clbRequestFiles.Items.Count == 0) clbRequestFiles.Items.Add(new CheckListBoxItem("", "Все файлы"));
                clbRequestFiles.Items.Add(new CheckListBoxItem(item.fullPath, name));
            }
        }

        private void AddOntologyinDB()
        {
            using (var conn = new NpgsqlConnection(_connStr))
            {
                try
                {
                    conn.Open();

                    using (var sqlCommand = new NpgsqlCommand
                    {
                        Connection = conn,
                        CommandText = "insert into owner values (default, @owner_name) ON CONFLICT ON CONSTRAINT name_constr DO NOTHING;"
                    })
                    {
                        sqlCommand.Parameters.AddWithValue("@owner_name", ontologyPath);

                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            tbFiles.Text = "";
            tbFiles.Text = (((ToolStripItem)sender).Tag as FileMetadata).text;
            foreach (ToolStripItem item in msFiles.Items)
            {
                item.BackColor = Color.Transparent;
                if (item == sender) item.BackColor = SystemColors.Highlight;
            }
        }

        private void DataButton_Click(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in msData.Items)
            {
                item.BackColor = Color.Transparent;
                if (item == sender) item.BackColor = SystemColors.Highlight;
            }

            string text = (((ToolStripItem)sender).Tag as FileMetadata).text;

            Dictionary<string, string> readyData = Parsing.Parser(text, nodes);
            (((ToolStripItem)sender).Tag as FileMetadata).readyData = readyData;
            (((ToolStripItem)sender).Tag as FileMetadata).entityName = entityName;
            (((ToolStripItem)sender).Tag as FileMetadata).date = date;
            AddDataInDB(ontologyPath, ((ToolStripItem)sender).Tag as FileMetadata);
            ShowData(readyData);
        }

        private void ShowData(Dictionary<string, string> readyData)
        {
            dgvData.Rows.Clear();
            foreach(var data in readyData)
            {
                dgvData.Rows.Add(data.Key, data.Value);
            }
        }

        private void AddDataInDB(string ontologyPath, FileMetadata fileMetadata)
        {
            string fullPath = fileMetadata.fullPath;
            Dictionary<string, string> readyData = fileMetadata.readyData;
            int numdoc_id;

            using (var conn = new NpgsqlConnection(_connStr))
            {
                try
                {
                    conn.Open();

                    using (var sqlCommand = new NpgsqlCommand
                    {
                        Connection = conn,
                        CommandText = @"insert into numdoc values (default, @fullPath, (select owner_id from owner where owner_name = @owner_name), @entityName, @date)
                                        ON CONFLICT ON CONSTRAINT duo_constr DO NOTHING; "
                    })
                    {
                        sqlCommand.Parameters.AddWithValue("@owner_name", ontologyPath);
                        sqlCommand.Parameters.AddWithValue("@fullPath", fullPath);
                        sqlCommand.Parameters.AddWithValue("@entityName", entityName);
                        sqlCommand.Parameters.AddWithValue("@date", date);

                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                            numdoc_id = GetID("select numdoc_id from numdoc where numdoc_name = @what", fullPath);
                            AddReadyDataFromDictionary(numdoc_id, readyData);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void AddReadyDataFromDictionary(int numdoc_id, Dictionary<string, string> readyData)
        {
            GetReadyCMBKey(readyData);
            int indicator_id = 0, value_id = 0, all_id = 0;
            foreach (var data in readyData)
            {
                //атрибут
                using (var conn = new NpgsqlConnection(_connStr))
                {
                    try
                    {
                        conn.Open();

                        using (var sqlCommand = new NpgsqlCommand
                        {
                            Connection = conn,
                            CommandText = @"insert into indicator values (default, @key, (select owner_id from owner where owner_name = @owner_name))
                                            ON CONFLICT ON CONSTRAINT duo2_constr DO NOTHING;"
                        })
                        {
                            sqlCommand.Parameters.AddWithValue("@owner_name", ontologyPath);
                            sqlCommand.Parameters.AddWithValue("@key", data.Key);

                            try
                            {
                                sqlCommand.ExecuteNonQuery();
                                indicator_id = GetID("select indicator_id from indicator where indicator_name = @what", data.Key);
                                
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }

                //значение
                using (var conn = new NpgsqlConnection(_connStr))
                {
                    try
                    {
                        conn.Open();

                        using (var sqlCommand = new NpgsqlCommand
                        {
                            Connection = conn,
                            CommandText = @"insert into valueitog values (default, @value)
                                            ON CONFLICT ON CONSTRAINT value_constr DO NOTHING;"
                        })
                        {
                            sqlCommand.Parameters.AddWithValue("@value", data.Value);

                            try
                            {
                                sqlCommand.ExecuteNonQuery();
                                value_id = GetID("select value_id from valueitog where value = @what", data.Value);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }

                //итоговое

                using (var conn = new NpgsqlConnection(_connStr))
                {
                    try
                    {
                        conn.Open();

                        using (var sqlCommand = new NpgsqlCommand
                        {
                            Connection = conn,
                            CommandText = @"insert into tableall values (default, @all_numdoc, @all_indicator, @all_valueitog)
                                            ON CONFLICT DO NOTHING "
                        })
                        {
                            sqlCommand.Parameters.AddWithValue("@all_numdoc", numdoc_id);
                            sqlCommand.Parameters.AddWithValue("@all_indicator", indicator_id);
                            sqlCommand.Parameters.AddWithValue("@all_valueitog", value_id);

                            try
                            {
                                sqlCommand.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }

        private int GetID(string command, string what)
        {
            int id = 0;
            using (var conn = new NpgsqlConnection(_connStr))
            {
                try
                {
                    conn.Open();

                    using (var sqlCommand = new NpgsqlCommand
                    {
                        Connection = conn,
                        CommandText = command
                    })
                    {
                        sqlCommand.Parameters.AddWithValue("@what", what);

                        try
                        {
                            id = (int)sqlCommand.ExecuteScalar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return id;
        }

        private void загрузитьФайлыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Документ Word|*.doc;*.docx";
            dlg.Multiselect = true;
            DialogResult dialogResult;

            string text = "";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (string path in dlg.FileNames)
                {
                    Word.Application app = new Word.Application();
                    Object filePath = path;

                    bool addornot = true, cont = false;
                    ToolStripItem updateItemInFiles = null;

                    string name = GetShortName(filePath.ToString());

                    foreach (ToolStripItem item in msFiles.Items)
                    {
                        if (item.ToolTipText == (string)filePath)
                        {
                            addornot = false;
                            updateItemInFiles = item;

                            dialogResult = MessageBox.Show("Файл " + name + " уже добавлен. Вы хотите обновить его?", "Внимание", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                continue;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                cont = true;
                                break;
                            }
                        }
                    }
                    if (cont) continue;

                    app.Documents.Open(ref filePath);

                    Word.Document doc = app.ActiveDocument;
                    // Нумерация параграфов начинается с одного
                    for (int i = 1; i <= doc.Paragraphs.Count; i++)
                    {
                        string parText = doc.Paragraphs[i].Range.Text;
                        text += parText;
                    }
                    app.Quit();
                    

                    ToolStripItem newitem = null;
                    if (addornot) newitem = new ToolStripMenuItem(name, null, FileButton_Click);
                    else newitem = updateItemInFiles;
                    newitem.Tag = new FileMetadata((string)filePath, text, null, null, null);
                    newitem.AutoToolTip = true;
                    newitem.ToolTipText = (string)filePath;

                    if (addornot) 
                    {
                        if (clbRequestFiles.Items.Count == 0) clbRequestFiles.Items.Add(new CheckListBoxItem("", "Все файлы"));
                        clbRequestFiles.Items.Add(new CheckListBoxItem((string)filePath, name));
                        msFiles.Items.Add(newitem);
                        ToolStripItem newitem2 = new ToolStripMenuItem(name, null, DataButton_Click);
                        newitem2.Tag = new FileMetadata((string)filePath, text, null, null, null);
                        newitem2.AutoToolTip = true;
                        newitem2.ToolTipText = (string)filePath;
                        msData.Items.Add(newitem2);
                    }
                    text = "";
                }
            }
            dialogResult = MessageBox.Show("Хотите ли вы извлечь данные сразу из всех файлов? \nВ ином случае данные нужно извлекать из документов по отдельности", "Внимание", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach(ToolStripItem item in msData.Items)
                {
                    DataButton_Click(item, new EventArgs());
                }
            }
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void открытьARMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("D:\\Hi, baby do you wanna be mine\\Университет\\! Курсовая работа\\ARM\\bin\\Debug\\ARM.exe");
        }

        private void почиститьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(_connStr))
            {
                try
                {
                    conn.Open();

                    using (var sqlCommand = new NpgsqlCommand
                    {
                        Connection = conn,
                        CommandText = @"delete from tableall;
                                        delete from indicator;
                                        delete from numdoc;
                                        delete from valueitog;"
                    })
                    {
                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                            dgvData.Rows.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MagicOntologies_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы хотите сохранить текущую сессию?", "Внимание", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            List<FileMetadata> files = new List<FileMetadata>();
            foreach (ToolStripItem item in msData.Items)
            {
                files.Add((FileMetadata)item.Tag);
            }
            OntologyConfig config = new OntologyConfig(ontologyPath, files, nodes, entityName, date);
            var dlg = new SaveFileDialog
            {
                Filter = "JSON|*.json"
            };

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            using (var fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
            {
                var jf = new JsonSerializer();
                jf.TypeNameHandling = TypeNameHandling.All;
                using (var w = new StreamWriter(fs))
                    jf.Serialize(w, config);
            }
        }

        private string searchValueOfIndicator(string what, string numdoc_name)
        {
            string Query = $@"select value from valueitog where value_id =
                            (select all_valueitog from tableall where all_numdoc = (select numdoc_id from numdoc
                            where numdoc_name = '{numdoc_name}')
                            and all_indicator = (select indicator_id from indicator where indicator_name =
                            (select {what} from numdoc where numdoc_name = '{numdoc_name}')))";

            string result = "";

            using (var conn = new NpgsqlConnection(_connStr))
            {
                try
                {
                    conn.Open();

                    using (var sqlCommand = new NpgsqlCommand
                    {
                        Connection = conn,
                        CommandText = Query
                    })
                    {
                        try
                        {
                            result = sqlCommand.ExecuteScalar().ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                }
            }

            return result;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tpRequest && clbRequestFiles.Items.Count == 0)
            {
                MessageBox.Show("Для работы с запросами добавьте файлы!");
                tabControl.SelectedTab = tpFiles;
            }

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            dgvAnswer.Rows.Clear();

            if (clbRequestFiles.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите файлы для поиска!");
                return;
            }


            if (cbKey.Text == "")
            {
                MessageBox.Show("Напишите атрибут поиска");
                return;
            }

            string request = QuestionLogic.QueryBuilder(clbRequestFiles.CheckedItems, clbRequestFiles.Items, cbKey.Text, tbKey.Text);

            MessageBox.Show(request);

            using (var conn = new NpgsqlConnection(_connStr))
            {
                try
                {
                    conn.Open();

                    using (var sqlCommand = new NpgsqlCommand
                    {
                        Connection = conn,
                        CommandText = request
                    })
                    {
                        try
                        {
                            var reader = sqlCommand.ExecuteReader();
                            while (reader.Read())
                            {
                                var value = reader["value"];
                                var numdoc_name = reader["numdoc_name"].ToString();
                                var entityname = searchValueOfIndicator("ind_entity_name", numdoc_name);
                                var date1 = searchValueOfIndicator("ind_date", numdoc_name);
                                var rowId = dgvAnswer.Rows.Add(numdoc_name, entityname, date1, value);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                }
            }
        }
    }
}
