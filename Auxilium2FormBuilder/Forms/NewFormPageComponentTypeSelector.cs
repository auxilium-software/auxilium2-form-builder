using Auxilium2FormBuilder.Enumerators;
using Auxilium2FormBuilder.FormDefinitionClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace Auxilium2FormBuilder.Forms
{
    public partial class NewFormPageComponentTypeSelector : Form
    {
        private int FormDefIndex;
        private int FormPageDefIndex;

        public NewFormPageComponentTypeSelector(int formDefIndex, int formPageDefIndex)
        {
            InitializeComponent();
            this.FormDefIndex = formDefIndex;
            this.FormPageDefIndex = formPageDefIndex;
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            FormPageComponentType type;
            if (radioButton_textField.Checked) type = FormPageComponentType.TEXT_FIELD;
            else if (radioButton_largeTextField.Checked) type = FormPageComponentType.LARGE_TEXT_FIELD;
            else if (radioButton_radioButtonField.Checked) type = FormPageComponentType.CHOICE_FIELD;
            else throw new Exception();


            FormPageComponent newComponent = new()
            {
                Type = type,

                Rows = null,
                Options = [],

                Label = "",
                DefaultValue = "",
                OutputVariable = "",
                Required = false
            };

            Program.FormDefinitions[this.FormDefIndex].Pages[this.FormPageDefIndex].Components.Add(newComponent);
            this.Close();
        }

        private void NewFormPageComponentTypeSelector_Load(object sender, EventArgs e)
        {

        }
    }
}
