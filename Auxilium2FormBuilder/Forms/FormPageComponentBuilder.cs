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

            Program.UpdateFormDefTempFiles();
        }

        private void FormPageComponentBuilder_Load(object sender, EventArgs e)
        {

        }

        private void textBox_label_TextChanged(object sender, EventArgs e)
            => Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].Label = textBox_label.Text;

        private void textBox_defaultValue_TextChanged(object sender, EventArgs e)
            => Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].DefaultValue = textBox_defaultValue.Text;

        private void textBox_outputVariable_TextChanged(object sender, EventArgs e)
            => Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components[this.FormPageComponentDefIndex].OutputVariable = textBox_outputVariable.Text;
    }
}
