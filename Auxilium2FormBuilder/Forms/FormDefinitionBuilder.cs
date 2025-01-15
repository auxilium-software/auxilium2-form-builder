using Auxilium2FormBuilder.Classes.FormDefinitionClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auxilium2FormBuilder.Forms
{
    public partial class FormDefinitionBuilder : Form
    {
        private int FormDefIndex;
        public FormDefinitionBuilder(int index)
        {
            InitializeComponent();
            this.FormDefIndex = index;
            this.overwriteFieldsWithFileData();
        }

        public void overwriteFieldsWithFileData()
        {
            this.textBox_fileUUID.Text = Program.FormDefinitions[this.FormDefIndex].ID.ToString();
            this.textBox1.Text = Program.FormDefinitions[this.FormDefIndex].TextPrefabPath;
            this.checkBox1.Checked = Program.FormDefinitions[this.FormDefIndex].ShouldFinalReview;

            this.listView_pages.Clear();
            this.listView_pages.Columns.Add("ID", 300);
            this.listView_pages.Columns.Add("Title", 300);
            this.listView_pages.Columns.Add("Description", 400);
            this.listView_pages.Columns.Add("If", 300);
            this.listView_pages.Columns.Add("Components", 120);

            int counter = 0;
            foreach (var pageDef in Program.FormDefinitions[this.FormDefIndex].Pages)
            {
                var item = new ListViewItem(pageDef.ID);
                item.SubItems.Add(pageDef.Title);
                item.SubItems.Add(pageDef.Description);
                item.SubItems.Add(pageDef.If);
                item.SubItems.Add(pageDef.Components.Count.ToString());
                item.Tag = counter;
                this.listView_pages.Items.Add(item);
                counter++;
            }
        }

        private void listView_pages_DoubleClick(object sender, EventArgs e)
        {
            if (this.listView_pages.SelectedItems.Count == 1)
            {
                new FormPageBuilder(formDefIndex: this.FormDefIndex, formPageDefIndex: System.Convert.ToInt32(this.listView_pages.SelectedItems[0].Tag)).ShowDialog();
                overwriteFieldsWithFileData();
            }
        }

        private void FormDefinitionBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
