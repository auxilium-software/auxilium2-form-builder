using Auxilium2FormBuilder.Classes.FormDefinitionClasses;
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
        private FormPage formPageDefinition;
        public FormPageBuilder(FormPage formPageDef)
        {
            InitializeComponent();
            this.formPageDefinition = formPageDef;
            this.overwriteFieldsWithFileData();
        }

        public void overwriteFieldsWithFileData()
        {
            this.textBox_pageID.Text = this.formPageDefinition.ID;
            this.textBox_title.Text = this.formPageDefinition.Title;
            this.textBox_description.Text = this.formPageDefinition.Description;
            this.textBox_ifStatement.Text = this.formPageDefinition.If;

            this.listView_pageComponents.Clear();
            this.listView_pageComponents.Columns.Add("Type", 150);
            this.listView_pageComponents.Columns.Add("Label", 150);
            this.listView_pageComponents.Columns.Add("Output Variable", 150);
            this.listView_pageComponents.Columns.Add("Default Value", 150);
            this.listView_pageComponents.Columns.Add("Required", 150);

            foreach (var pageDef in this.formPageDefinition.Components)
            {
                var item = new ListViewItem(pageDef.Type);
                item.SubItems.Add(pageDef.Label);
                item.SubItems.Add(pageDef.OutputVariable);
                item.SubItems.Add(pageDef.DefaultValue);
                item.SubItems.Add(pageDef.Required.ToString());
                item.Tag = pageDef;
                this.listView_pageComponents.Items.Add(item);
            }
        }

        private void FormPageBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
