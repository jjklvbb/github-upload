using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MagicOntologies
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnOpenOntology_Click(object sender, EventArgs e)
        {
            JObject str;
            var dlg = new OpenFileDialog();
            dlg.Filter = "Файл онтологии|*.ont";
            dlg.Multiselect = false;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string ontologyPath = dlg.FileName;
                str = JObject.Parse(File.ReadAllText(ontologyPath));
                List<JToken> nodes = str["nodes"].ToList();

                Parsing.FindMetaAttribute(nodes, str, out string entityName, out string date);

                var magicOntologies = new MagicOntologies(ontologyPath, nodes, str, entityName, date);
                magicOntologies.ShowDialog();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "JSON|*.json";

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            OntologyConfig config;

            using (var fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
            {
                var jf = new JsonSerializer();
                jf.TypeNameHandling = TypeNameHandling.All;
                using (var r = new StreamReader(fs))
                    config = (OntologyConfig)jf.Deserialize(r, typeof(OntologyConfig));
            }

            var magicOntologies = new MagicOntologies(config);
            magicOntologies.ShowDialog();
            this.Close();
        }
    }
}
