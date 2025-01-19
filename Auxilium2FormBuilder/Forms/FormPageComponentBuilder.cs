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
    public partial class FormPageComponentBuilder : Form
    {
        private int FormDefIndex;
        private int FormPageDefIndex;
        private int FormPageComponentDefIndex;

        public FormPageComponentBuilder(int formDefIndex, int formPageDefIndex, int formPageComponentDefIndex)
        {
            InitializeComponent();
            this.FormDefIndex = formDefIndex;
            this.FormPageDefIndex = formPageDefIndex;
            this.FormPageComponentDefIndex = formPageComponentDefIndex;
            this.overwriteFieldsWithFileData();
        }

        public void overwriteFieldsWithFileData()
        {
            this.comboBox_type.Text = Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].Type.StringValue();
            this.textBox_label.Text = Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].Label;
            this.textBox_defaultValue.Text = Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].DefaultValue;
            this.textBox_outputVariable.Text = Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].OutputVariable;

            if (Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].Type == Enumerators.FormPageComponentType.CHOICE_FIELD)
            {
                this.groupBox_choiceFieldOptions.Enabled = true;
            }

            listView_options.Clear();
            this.listView_options.Clear();
            this.listView_options.Columns.Add("Strong Label", 150);
            this.listView_options.Columns.Add("Secondary Label", 150);
            this.listView_options.Columns.Add("Value", 150);

            int counter = 0;
            if (Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].Options != null)
            {
                foreach (var optionDef in Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].Options)
                {
                    var item = new ListViewItem(optionDef.LabelStrong);
                    item.SubItems.Add(optionDef.LabelSecondary);
                    item.SubItems.Add(optionDef.Value);
                    item.Tag = counter;
                    this.listView_options.Items.Add(item);
                    counter++;
                }
            }

            Program.UpdateFormDefTempFiles();
        }

        private void FormPageComponentBuilder_Load(object sender, EventArgs e)
        {

        }

        private void textBox_label_TextChanged(object sender, EventArgs e)
        {
            Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].Label = textBox_label.Text;
            Program.UpdateFormDefTempFiles();
        }

        private void textBox_defaultValue_TextChanged(object sender, EventArgs e)
        {
            Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].DefaultValue = textBox_defaultValue.Text;
            Program.UpdateFormDefTempFiles();
        }

        private void textBox_outputVariable_TextChanged(object sender, EventArgs e)
        {
            Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].OutputVariable = textBox_outputVariable.Text;
            Program.UpdateFormDefTempFiles();
        }






        private void toolStripButton_choiceFieldOptions_newOption_Click(object sender, EventArgs e)
        {
            Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].Options?.Add(
                new FormComponentChoiceFieldOption()
                {
                    LabelStrong = "New option",
                    LabelSecondary = null,
                    Value = "NEW_OPTION",
                }
            );
            this.overwriteFieldsWithFileData();
        }

        private void toolStripButton_choiceFieldOptions_editSelectedOption_Click(object sender, EventArgs e)
        {
            new FormPageChoiceFieldComponentBuilder(this.FormDefIndex, this.FormPageDefIndex, this.FormPageComponentDefIndex, System.Convert.ToInt32(this.listView_options.SelectedItems[0].Tag)).ShowDialog();
            this.overwriteFieldsWithFileData();
        }

        private void toolStripButton_choiceFieldOptions_deleteSelectedOption_Click(object sender, EventArgs e)
        {

        }






        private void listView_options_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView_options.SelectedItems.Count == 1)
            {
                this.toolStripButton_choiceFieldOptions_editSelectedOption.Enabled = true;
                this.toolStripButton_choiceFieldOptions_deleteSelectedOption.Enabled = true;
            }
            else
            {
                this.toolStripButton_choiceFieldOptions_editSelectedOption.Enabled = false;
                this.toolStripButton_choiceFieldOptions_deleteSelectedOption.Enabled = false;
            }
        }
        private void listView_options_DoubleClick(object sender, EventArgs e)
        {
            if (this.listView_options.SelectedItems.Count == 1)
            {
                new FormPageChoiceFieldComponentBuilder(this.FormDefIndex, this.FormPageDefIndex, this.FormPageComponentDefIndex, System.Convert.ToInt32(this.listView_options.SelectedItems[0].Tag)).ShowDialog();
                this.overwriteFieldsWithFileData();
            }
        }

    }
}
