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
    public partial class FormDefinitionBuilder : Form
    {
        private FormDefinition formDefinition;
        public FormDefinitionBuilder(FormDefinition formDef)
        {
            InitializeComponent();
            this.formDefinition = formDef;
        }

        private void FormDefinitionBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
