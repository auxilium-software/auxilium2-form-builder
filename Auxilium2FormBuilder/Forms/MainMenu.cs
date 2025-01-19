using Auxilium2FormBuilder.FormDefinitionClasses;
using Auxilium2FormBuilder.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Auxilium2FormBuilder.Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }



        private void UpdateFormDefinitionListView()
        {
            Program.UpdateFromFiles();

            this.listView1.Clear();
            this.listView1.Columns.Add("UUID", 300);
            this.listView1.Columns.Add("Text Prefab Path", 200);
            this.listView1.Columns.Add("Pages", 130);
            this.listView1.Columns.Add("Final Review?", 130);
            this.listView1.Columns.Add("Review Steps", 130);
            this.listView1.Columns.Add("On Submit Steps", 130);

            int counter = 0;
            foreach (var pageDef in Program.FormDefinitions)
            {
                ListViewItem item = new(pageDef.ID.ToString());
                item.SubItems.Add(pageDef.TextPrefabPath);
                item.SubItems.Add(pageDef.Pages.Count().ToString());

                item.Tag = counter;

                this.listView1.Items.Add(item);
                counter++;
            }
            Program.UpdateFormDefTempFiles();
        }

        private void toolStrip_main__dropDownButton_file__toolStripMenuItem_exit_Click(object sender, EventArgs e)
            => this.Close();

        private void toolStrip_main__dropDownButton_file__toolStripMenuItem_setFormDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Program.FormDefinitionDirectory = dialog.SelectedPath;
                Program.LocalisedStringsFilePath = Path.GetDirectoryName(Path.GetDirectoryName(dialog.SelectedPath)) + "/Configuration/Localisation/LocalisedStrings.json";
                Program.UpdateFormDefTempFiles();

                this.Text = "Form Builder operating on " + Program.FormDefinitionDirectory;
                this.toolStrip_main__dropDownButton_file__toolStripMenuItem_newFormDefinition.Enabled = true;
                toolStrip_main__dropDownButton_file__toolStripMenuItem_saveFormDefinitions.Enabled = true;
                this.UpdateFormDefinitionListView();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 1)
            {
                new FormDefinitionBuilder(index: System.Convert.ToInt32(listView1.SelectedItems[0].Tag)).ShowDialog();
                UpdateFormDefinitionListView();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
        }

        private void toolStrip_main__dropDownButton_file__toolStripMenuItem_newFormDefinition_Click(object sender, EventArgs e)
        {
            FormDefinition newFormDef = new()
            {
                ID = Guid.NewGuid(),
                TextPrefabPath = "forms/new_form",
                Pages = [],
                ShouldFinalReview = false,
                Review = new FinalReview()
                {
                    Components = []
                },
                OnSubmitOperations = []
            };
            Program.FormDefinitions.Add(newFormDef);
            Program.UpdateFormDefFiles();
            UpdateFormDefinitionListView();
        }

        private void toolStrip_main__dropDownButton_file__toolStripMenuItem_saveFormDefinitions_Click(object sender, EventArgs e)
        {
            Program.UpdateFormDefFiles();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
