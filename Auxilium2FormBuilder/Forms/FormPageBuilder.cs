using Auxilium2FormBuilder.FormDefinitionClasses;
using Auxilium2FormBuilder.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auxilium2FormBuilder.Forms
{
    public partial class FormPageBuilder : Form
    {
        private int FormDefIndex;
        private int FormPageDefIndex;
        public FormPageBuilder(int formDefIndex, int formPageDefIndex)
        {
            InitializeComponent();
            this.FormDefIndex = formDefIndex;
            this.FormPageDefIndex = formPageDefIndex;
            this.overwriteFieldsWithFileData();
        }

        public void overwriteFieldsWithFileData()
        {
            this.textBox_pageID.Text = Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].ID;
            this.textBox_title.Text = Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Title;
            this.textBox_description.Text = Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Description;
            this.textBox_ifStatement.Text = Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].If;

            this.listView_pageComponents.Clear();
            this.listView_pageComponents.Columns.Add("Type", 150);
            this.listView_pageComponents.Columns.Add("Label", 150);
            this.listView_pageComponents.Columns.Add("Output Variable", 150);
            this.listView_pageComponents.Columns.Add("Default Value", 150);
            this.listView_pageComponents.Columns.Add("Required", 150);

            int counter = 0;
            foreach (var pageDef in Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components)
            {
                var item = new ListViewItem(pageDef.Type.StringValue());
                item.SubItems.Add(pageDef.Label);
                item.SubItems.Add(pageDef.OutputVariable);
                item.SubItems.Add(pageDef.DefaultValue);
                item.SubItems.Add(pageDef.Required.ToString());
                item.Tag = counter;
                this.listView_pageComponents.Items.Add(item);
                counter++;
            }
        }

        private void FormPageBuilder_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton_pageComponents_newComponent_Click(object sender, EventArgs e)
        {
            new NewFormPageComponentTypeSelector(formDefIndex: this.FormDefIndex, formPageDefIndex: this.FormPageDefIndex).ShowDialog();
            overwriteFieldsWithFileData();
            new FormPageComponentBuilder(formDefIndex: this.FormDefIndex, formPageDefIndex: this.FormPageDefIndex, formPageComponentDefIndex: this.listView_pageComponents.Items.Count - 1).ShowDialog();
        }

        private void toolStripButton_pageComponents_editSelectedComponent_Click(object sender, EventArgs e)
        {
            new FormPageComponentBuilder(
                formDefIndex: this.FormDefIndex,
                formPageDefIndex: this.FormPageDefIndex,
                formPageComponentDefIndex: System.Convert.ToInt32(this.listView_pageComponents.SelectedItems[0].Tag)
                ).ShowDialog();
            overwriteFieldsWithFileData();
        }

        private void toolStripButton_pageComponents_deleteSelectedComponent_Click(object sender, EventArgs e)
        {
            Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components.RemoveAt(System.Convert.ToInt32(this.listView_pageComponents.Tag));
            overwriteFieldsWithFileData();
        }

        private void listView_pageComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView_pageComponents.SelectedItems.Count == 1)
            {
                this.toolStripButton_pageComponents_editSelectedComponent.Enabled = true;
                this.toolStripButton_pageComponents_deleteSelectedComponent.Enabled = true;
            }
            else
            {
                this.toolStripButton_pageComponents_editSelectedComponent.Enabled = false;
                this.toolStripButton_pageComponents_deleteSelectedComponent.Enabled = false;
            }
        }
    }
}
