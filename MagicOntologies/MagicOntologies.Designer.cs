
namespace MagicOntologies
{
    partial class MagicOntologies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagicOntologies));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpDB = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msDB = new System.Windows.Forms.MenuStrip();
            this.почиститьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpFiles = new System.Windows.Forms.TabPage();
            this.tbFiles = new System.Windows.Forms.TextBox();
            this.msFiles = new System.Windows.Forms.MenuStrip();
            this.загрузитьФайлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpDataExtraction = new System.Windows.Forms.TabPage();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.clmnIndicator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msData = new System.Windows.Forms.MenuStrip();
            this.tpRequest = new System.Windows.Forms.TabPage();
            this.gbAnswer = new System.Windows.Forms.GroupBox();
            this.dgvAnswer = new System.Windows.Forms.DataGridView();
            this.AnswerFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerEntityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbQuestion = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbKey = new System.Windows.Forms.ComboBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbRequestFiles = new System.Windows.Forms.GroupBox();
            this.clbRequestFiles = new System.Windows.Forms.CheckedListBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьARMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tpDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.msDB.SuspendLayout();
            this.tpFiles.SuspendLayout();
            this.msFiles.SuspendLayout();
            this.tpDataExtraction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tpRequest.SuspendLayout();
            this.gbAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswer)).BeginInit();
            this.gbQuestion.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.gbRequestFiles.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpDB);
            this.tabControl.Controls.Add(this.tpFiles);
            this.tabControl.Controls.Add(this.tpDataExtraction);
            this.tabControl.Controls.Add(this.tpRequest);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1029, 625);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tpDB
            // 
            this.tpDB.Controls.Add(this.pictureBox1);
            this.tpDB.Controls.Add(this.msDB);
            this.tpDB.Location = new System.Drawing.Point(4, 25);
            this.tpDB.Name = "tpDB";
            this.tpDB.Padding = new System.Windows.Forms.Padding(3);
            this.tpDB.Size = new System.Drawing.Size(1021, 596);
            this.tpDB.TabIndex = 0;
            this.tpDB.Text = "База данных";
            this.tpDB.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1015, 562);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // msDB
            // 
            this.msDB.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msDB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.почиститьБДToolStripMenuItem});
            this.msDB.Location = new System.Drawing.Point(3, 3);
            this.msDB.Name = "msDB";
            this.msDB.Size = new System.Drawing.Size(1015, 28);
            this.msDB.TabIndex = 0;
            this.msDB.Text = "msDB";
            // 
            // почиститьБДToolStripMenuItem
            // 
            this.почиститьБДToolStripMenuItem.Name = "почиститьБДToolStripMenuItem";
            this.почиститьБДToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.почиститьБДToolStripMenuItem.Text = "Почистить БД";
            this.почиститьБДToolStripMenuItem.Click += new System.EventHandler(this.почиститьБДToolStripMenuItem_Click);
            // 
            // tpFiles
            // 
            this.tpFiles.Controls.Add(this.tbFiles);
            this.tpFiles.Controls.Add(this.msFiles);
            this.tpFiles.Location = new System.Drawing.Point(4, 25);
            this.tpFiles.Name = "tpFiles";
            this.tpFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tpFiles.Size = new System.Drawing.Size(1021, 596);
            this.tpFiles.TabIndex = 1;
            this.tpFiles.Text = "Файлы";
            this.tpFiles.UseVisualStyleBackColor = true;
            // 
            // tbFiles
            // 
            this.tbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFiles.Location = new System.Drawing.Point(150, 3);
            this.tbFiles.Multiline = true;
            this.tbFiles.Name = "tbFiles";
            this.tbFiles.ReadOnly = true;
            this.tbFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFiles.Size = new System.Drawing.Size(868, 590);
            this.tbFiles.TabIndex = 1;
            // 
            // msFiles
            // 
            this.msFiles.BackColor = System.Drawing.SystemColors.Control;
            this.msFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.msFiles.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьФайлыToolStripMenuItem});
            this.msFiles.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.msFiles.Location = new System.Drawing.Point(3, 3);
            this.msFiles.Name = "msFiles";
            this.msFiles.ShowItemToolTips = true;
            this.msFiles.Size = new System.Drawing.Size(147, 590);
            this.msFiles.Stretch = false;
            this.msFiles.TabIndex = 0;
            this.msFiles.Text = "msFiles";
            // 
            // загрузитьФайлыToolStripMenuItem
            // 
            this.загрузитьФайлыToolStripMenuItem.AutoToolTip = true;
            this.загрузитьФайлыToolStripMenuItem.Name = "загрузитьФайлыToolStripMenuItem";
            this.загрузитьФайлыToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.загрузитьФайлыToolStripMenuItem.Text = "Загрузить файлы";
            this.загрузитьФайлыToolStripMenuItem.Click += new System.EventHandler(this.загрузитьФайлыToolStripMenuItem_Click);
            // 
            // tpDataExtraction
            // 
            this.tpDataExtraction.Controls.Add(this.dgvData);
            this.tpDataExtraction.Controls.Add(this.msData);
            this.tpDataExtraction.Location = new System.Drawing.Point(4, 25);
            this.tpDataExtraction.Name = "tpDataExtraction";
            this.tpDataExtraction.Size = new System.Drawing.Size(1021, 596);
            this.tpDataExtraction.TabIndex = 2;
            this.tpDataExtraction.Text = "Извлечение данных";
            this.tpDataExtraction.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnIndicator,
            this.clmnValue});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(30, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(991, 596);
            this.dgvData.TabIndex = 1;
            // 
            // clmnIndicator
            // 
            this.clmnIndicator.HeaderText = "Атрибут";
            this.clmnIndicator.MinimumWidth = 6;
            this.clmnIndicator.Name = "clmnIndicator";
            this.clmnIndicator.ReadOnly = true;
            // 
            // clmnValue
            // 
            this.clmnValue.HeaderText = "Значение";
            this.clmnValue.MinimumWidth = 6;
            this.clmnValue.Name = "clmnValue";
            this.clmnValue.ReadOnly = true;
            // 
            // msData
            // 
            this.msData.Dock = System.Windows.Forms.DockStyle.Left;
            this.msData.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msData.Location = new System.Drawing.Point(0, 0);
            this.msData.Name = "msData";
            this.msData.ShowItemToolTips = true;
            this.msData.Size = new System.Drawing.Size(30, 596);
            this.msData.TabIndex = 0;
            this.msData.Text = "menuStrip1";
            // 
            // tpRequest
            // 
            this.tpRequest.Controls.Add(this.gbAnswer);
            this.tpRequest.Controls.Add(this.gbQuestion);
            this.tpRequest.Controls.Add(this.gbRequestFiles);
            this.tpRequest.Location = new System.Drawing.Point(4, 25);
            this.tpRequest.Name = "tpRequest";
            this.tpRequest.Size = new System.Drawing.Size(1021, 596);
            this.tpRequest.TabIndex = 3;
            this.tpRequest.Text = "Запросы на ЕЯ";
            this.tpRequest.UseVisualStyleBackColor = true;
            // 
            // gbAnswer
            // 
            this.gbAnswer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbAnswer.Controls.Add(this.dgvAnswer);
            this.gbAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAnswer.Location = new System.Drawing.Point(0, 169);
            this.gbAnswer.Name = "gbAnswer";
            this.gbAnswer.Size = new System.Drawing.Size(1021, 427);
            this.gbAnswer.TabIndex = 3;
            this.gbAnswer.TabStop = false;
            this.gbAnswer.Text = "Ответ";
            // 
            // dgvAnswer
            // 
            this.dgvAnswer.AllowUserToAddRows = false;
            this.dgvAnswer.AllowUserToDeleteRows = false;
            this.dgvAnswer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnswer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAnswer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnswer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnswerFilePath,
            this.AnswerEntityName,
            this.AnswerDate,
            this.Answer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnswer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAnswer.Location = new System.Drawing.Point(3, 18);
            this.dgvAnswer.Name = "dgvAnswer";
            this.dgvAnswer.ReadOnly = true;
            this.dgvAnswer.RowHeadersWidth = 51;
            this.dgvAnswer.RowTemplate.Height = 24;
            this.dgvAnswer.Size = new System.Drawing.Size(1015, 406);
            this.dgvAnswer.TabIndex = 1;
            // 
            // AnswerFilePath
            // 
            this.AnswerFilePath.FillWeight = 81.27129F;
            this.AnswerFilePath.HeaderText = "Полный путь документа";
            this.AnswerFilePath.MinimumWidth = 6;
            this.AnswerFilePath.Name = "AnswerFilePath";
            this.AnswerFilePath.ReadOnly = true;
            // 
            // AnswerEntityName
            // 
            this.AnswerEntityName.FillWeight = 103.5089F;
            this.AnswerEntityName.HeaderText = "Имя сущности";
            this.AnswerEntityName.MinimumWidth = 6;
            this.AnswerEntityName.Name = "AnswerEntityName";
            this.AnswerEntityName.ReadOnly = true;
            // 
            // AnswerDate
            // 
            this.AnswerDate.FillWeight = 88.45732F;
            this.AnswerDate.HeaderText = "Дата";
            this.AnswerDate.MinimumWidth = 6;
            this.AnswerDate.Name = "AnswerDate";
            this.AnswerDate.ReadOnly = true;
            // 
            // Answer
            // 
            this.Answer.FillWeight = 126.7625F;
            this.Answer.HeaderText = "Ответ";
            this.Answer.MinimumWidth = 6;
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            // 
            // gbQuestion
            // 
            this.gbQuestion.AutoSize = true;
            this.gbQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbQuestion.Controls.Add(this.flowLayoutPanel2);
            this.gbQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQuestion.Location = new System.Drawing.Point(0, 115);
            this.gbQuestion.Name = "gbQuestion";
            this.gbQuestion.Size = new System.Drawing.Size(1021, 54);
            this.gbQuestion.TabIndex = 2;
            this.gbQuestion.TabStop = false;
            this.gbQuestion.Text = "Введите атрибут поиска и ключевое слово (не обязательно)";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.cbKey);
            this.flowLayoutPanel2.Controls.Add(this.tbKey);
            this.flowLayoutPanel2.Controls.Add(this.btnSearch);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1015, 33);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // cbKey
            // 
            this.cbKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKey.FormattingEnabled = true;
            this.cbKey.Location = new System.Drawing.Point(3, 3);
            this.cbKey.MaxDropDownItems = 15;
            this.cbKey.Name = "cbKey";
            this.cbKey.Size = new System.Drawing.Size(356, 24);
            this.cbKey.Sorted = true;
            this.cbKey.TabIndex = 0;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(365, 3);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(327, 22);
            this.tbKey.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(698, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // gbRequestFiles
            // 
            this.gbRequestFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbRequestFiles.Controls.Add(this.clbRequestFiles);
            this.gbRequestFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbRequestFiles.Location = new System.Drawing.Point(0, 0);
            this.gbRequestFiles.Name = "gbRequestFiles";
            this.gbRequestFiles.Size = new System.Drawing.Size(1021, 115);
            this.gbRequestFiles.TabIndex = 0;
            this.gbRequestFiles.TabStop = false;
            this.gbRequestFiles.Text = "Выберите файлы для работы";
            // 
            // clbRequestFiles
            // 
            this.clbRequestFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbRequestFiles.FormattingEnabled = true;
            this.clbRequestFiles.Location = new System.Drawing.Point(3, 18);
            this.clbRequestFiles.MultiColumn = true;
            this.clbRequestFiles.Name = "clbRequestFiles";
            this.clbRequestFiles.Size = new System.Drawing.Size(1015, 94);
            this.clbRequestFiles.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.открытьARMToolStripMenuItem1});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1029, 28);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // открытьARMToolStripMenuItem1
            // 
            this.открытьARMToolStripMenuItem1.Name = "открытьARMToolStripMenuItem1";
            this.открытьARMToolStripMenuItem1.Size = new System.Drawing.Size(117, 24);
            this.открытьARMToolStripMenuItem1.Text = "Открыть ARM";
            this.открытьARMToolStripMenuItem1.Click += new System.EventHandler(this.открытьARMToolStripMenuItem1_Click);
            // 
            // MagicOntologies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 653);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msDB;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MagicOntologies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magnolis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MagicOntologies_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tpDB.ResumeLayout(false);
            this.tpDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.msDB.ResumeLayout(false);
            this.msDB.PerformLayout();
            this.tpFiles.ResumeLayout(false);
            this.tpFiles.PerformLayout();
            this.msFiles.ResumeLayout(false);
            this.msFiles.PerformLayout();
            this.tpDataExtraction.ResumeLayout(false);
            this.tpDataExtraction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tpRequest.ResumeLayout(false);
            this.tpRequest.PerformLayout();
            this.gbAnswer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswer)).EndInit();
            this.gbQuestion.ResumeLayout(false);
            this.gbQuestion.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.gbRequestFiles.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpDB;
        private System.Windows.Forms.MenuStrip msDB;
        private System.Windows.Forms.TabPage tpFiles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem почиститьБДToolStripMenuItem;
        private System.Windows.Forms.TabPage tpDataExtraction;
        private System.Windows.Forms.TabPage tpRequest;
        private System.Windows.Forms.TextBox tbFiles;
        private System.Windows.Forms.MenuStrip msFiles;
        private System.Windows.Forms.ToolStripMenuItem загрузитьФайлыToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьARMToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.MenuStrip msData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnIndicator;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnValue;
        private System.Windows.Forms.GroupBox gbRequestFiles;
        private System.Windows.Forms.GroupBox gbAnswer;
        private System.Windows.Forms.GroupBox gbQuestion;
        private System.Windows.Forms.CheckedListBox clbRequestFiles;
        private System.Windows.Forms.DataGridView dgvAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerEntityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ComboBox cbKey;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbKey;
    }
}