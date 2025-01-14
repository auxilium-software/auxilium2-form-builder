using Auxilium2FormBuilder.Classes.FormDefinitionClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auxilium2FormBuilder.Forms
{
    public partial class MainMenu : Form
    {
        internal string? FormDefinitionDirectory { get; set; } = null;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void UpdateFormDefinitionListView()
        {
            this.listView1.Clear();
            this.listView1.Columns.Add("UUID", 300);
            this.listView1.Columns.Add("Text Prefab Path", 200);
            this.listView1.Columns.Add("Pages", 130);
            this.listView1.Columns.Add("Final Review?", 130);
            this.listView1.Columns.Add("Review Steps", 130);
            this.listView1.Columns.Add("On Submit Steps", 130);

            string[] files = Directory.GetFiles(path: this.FormDefinitionDirectory, searchPattern: "*.json", searchOption: SearchOption.AllDirectories);
            foreach (string file in files)
            {
                string fileContents = File.ReadAllText(file);
                var jsonContents = JsonObject.Parse(fileContents);

                FormDefinition formDefinition = FormDefinition.FromJSON(jsonNode: jsonContents);

                ListViewItem item = new(file.Replace(oldValue: this.FormDefinitionDirectory + "\\", newValue: "").Replace(oldValue: ".json", newValue: ""));
                item.SubItems.Add(formDefinition.TextPrefabPath);
                item.SubItems.Add(formDefinition.Pages.Count().ToString());

                item.Tag = formDefinition;

                this.listView1.Items.Add(item);
            }
            this.listView1.Update();
        }

        private void toolStrip_main__dropDownButton_file__toolStripMenuItem_exit_Click(object sender, EventArgs e) => this.Close();

        private void toolStrip_main__dropDownButton_file__toolStripMenuItem_setFormDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.FormDefinitionDirectory = dialog.SelectedPath;
                this.Text = "Form Builder operating on " + this.FormDefinitionDirectory;
                this.toolStrip_main__dropDownButton_file__toolStripMenuItem_newFormDefinition.Enabled = true;
                this.UpdateFormDefinitionListView();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if(this.listView1.SelectedItems.Count == 1)
            {
                new FormDefinitionBuilder((FormDefinition)this.listView1.SelectedItems[0].Tag).ShowDialog();
            }
        }
    }
}
