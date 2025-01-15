using Auxilium2FormBuilder.Classes.FormDefinitionClasses;
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
            string type;
            if (radioButton_textField.Checked) type = "TEXT_FIELD";
            else if (radioButton_largeTextField.Checked) type = "LARGE_TEXT_FIELD";
            else if (radioButton_radioButtonField.Checked) type = "RADIO_BUTTON";
            else throw new Exception();


            FormPageComponent newComponent = new()
            {
                Type = type,
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
