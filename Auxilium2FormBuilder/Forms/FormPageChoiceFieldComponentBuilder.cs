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
    public partial class FormPageChoiceFieldComponentBuilder : Form
    {
        private int FormDefIndex;
        private int FormPageDefIndex;
        private int FormPageComponentDefIndex;
        private int FormPageComponentOptionDefIndex;


        public FormPageChoiceFieldComponentBuilder(int formDefIndex, int formPageDefIndex, int formPageComponentDefIndex, int formPageComponentOptionDefIndex)
        {
            InitializeComponent();
            this.FormDefIndex = formDefIndex;
            this.FormPageDefIndex = formPageDefIndex;
            this.FormPageComponentDefIndex = formPageComponentDefIndex;
            FormPageComponentOptionDefIndex = formPageComponentOptionDefIndex;
            this.overwriteFieldsWithFileData();
        }

        public void overwriteFieldsWithFileData()
        {
            this.textBox_strongLabel.Text = Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].Options[this.FormPageComponentOptionDefIndex].LabelStrong;
            this.textBox_secondaryLabel.Text = Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].Options[this.FormPageComponentOptionDefIndex].LabelSecondary;
            this.textBox_value.Text = Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].Options[this.FormPageComponentOptionDefIndex].Value;

            Program.UpdateFormDefTempFiles();
        }

        private void FormPageChoiceFieldComponentBuilder_Load(object sender, EventArgs e)
        {

        }



        private void textBox_strongLabel_TextChanged(object sender, EventArgs e)
        {
            Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].Options[this.FormPageComponentOptionDefIndex].LabelStrong = this.textBox_strongLabel.Text;
            this.overwriteFieldsWithFileData();
        }

        private void textBox_secondaryLabel_TextChanged(object sender, EventArgs e)
        {
            Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].Options[this.FormPageComponentOptionDefIndex].LabelSecondary = this.textBox_secondaryLabel.Text;
            this.overwriteFieldsWithFileData();
        }

        private void textBox_value_TextChanged(object sender, EventArgs e)
        {
            Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].Options[this.FormPageComponentOptionDefIndex].Value = this.textBox_value.Text;
            this.overwriteFieldsWithFileData();
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
