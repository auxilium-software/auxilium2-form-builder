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
        private FormDefinition formDefinition;
        public FormDefinitionBuilder(FormDefinition formDef)
        {
            InitializeComponent();
            this.formDefinition = formDef;
            this.overwriteFieldsWithFileData();
        }

        public void overwriteFieldsWithFileData()
        {
            this.textBox1.Text = this.formDefinition.TextPrefabPath;
            this.checkBox1.Checked = this.formDefinition.FinalReview;

            this.listView_pages.Clear();
            this.listView_pages.Columns.Add("ID", 300);
            this.listView_pages.Columns.Add("Title", 300);
            this.listView_pages.Columns.Add("Description", 400);
            this.listView_pages.Columns.Add("If", 300);
            this.listView_pages.Columns.Add("Components", 120);

            foreach (var pageDef in this.formDefinition.Pages)
            {
                var item = new ListViewItem(pageDef.ID);
                item.SubItems.Add(pageDef.Title);
                item.SubItems.Add(pageDef.Description);
                item.SubItems.Add(pageDef.If);
                item.SubItems.Add(pageDef.Components.Length.ToString());
                item.Tag = pageDef;
                this.listView_pages.Items.Add(item);
            }
        }

        private void FormDefinitionBuilder_Load(object sender, EventArgs e)
        {

        }

        private void listView_pages_DoubleClick(object sender, EventArgs e)
        {
            if (this.listView_pages.SelectedItems.Count == 1)
            {
                new FormPageBuilder(formPageDef: (FormPage)this.listView_pages.SelectedItems[0].Tag).ShowDialog();
            }
        }
    }
}
