namespace Auxilium2FormBuilder.Forms
{
    partial class FormPageComponentBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPageComponentBuilder));
            groupBox2 = new GroupBox();
            groupBox_choiceFieldOptions = new GroupBox();
            listView_options = new ListView();
            toolStrip1 = new ToolStrip();
            toolStripButton_choiceFieldOptions_newOption = new ToolStripButton();
            toolStripButton_choiceFieldOptions_editSelectedOption = new ToolStripButton();
            toolStripButton_choiceFieldOptions_deleteSelectedOption = new ToolStripButton();
            groupBox1 = new GroupBox();
            groupBox_outputVariable = new GroupBox();
            textBox_outputVariable = new TextBox();
            groupBox_defaultValue = new GroupBox();
            textBox_defaultValue = new TextBox();
            groupBox_label = new GroupBox();
            textBox_label = new TextBox();
            groupBox_type = new GroupBox();
            comboBox_type = new ComboBox();
            groupBox_required = new GroupBox();
            checkBox_required = new CheckBox();
            groupBox2.SuspendLayout();
            groupBox_choiceFieldOptions.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox_outputVariable.SuspendLayout();
            groupBox_defaultValue.SuspendLayout();
            groupBox_label.SuspendLayout();
            groupBox_type.SuspendLayout();
            groupBox_required.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox_choiceFieldOptions);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(400, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(763, 537);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Page Components";
            // 
            // groupBox_choiceFieldOptions
            // 
            groupBox_choiceFieldOptions.Controls.Add(listView_options);
            groupBox_choiceFieldOptions.Controls.Add(toolStrip1);
            groupBox_choiceFieldOptions.Dock = DockStyle.Top;
            groupBox_choiceFieldOptions.Enabled = false;
            groupBox_choiceFieldOptions.Location = new Point(3, 23);
            groupBox_choiceFieldOptions.Name = "groupBox_choiceFieldOptions";
            groupBox_choiceFieldOptions.Size = new Size(757, 250);
            groupBox_choiceFieldOptions.TabIndex = 1;
            groupBox_choiceFieldOptions.TabStop = false;
            groupBox_choiceFieldOptions.Text = "Options (Choice Field Only)";
            // 
            // listView_options
            // 
            listView_options.Dock = DockStyle.Fill;
            listView_options.FullRowSelect = true;
            listView_options.Location = new Point(3, 50);
            listView_options.MultiSelect = false;
            listView_options.Name = "listView_options";
            listView_options.Size = new Size(751, 197);
            listView_options.TabIndex = 4;
            listView_options.UseCompatibleStateImageBehavior = false;
            listView_options.View = View.Details;
            listView_options.SelectedIndexChanged += listView_options_SelectedIndexChanged;
            listView_options.DoubleClick += listView_options_DoubleClick;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton_choiceFieldOptions_newOption, toolStripButton_choiceFieldOptions_editSelectedOption, toolStripButton_choiceFieldOptions_deleteSelectedOption });
            toolStrip1.Location = new Point(3, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(751, 27);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_choiceFieldOptions_newOption
            // 
            toolStripButton_choiceFieldOptions_newOption.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_choiceFieldOptions_newOption.Image = (Image)resources.GetObject("toolStripButton_choiceFieldOptions_newOption.Image");
            toolStripButton_choiceFieldOptions_newOption.ImageTransparentColor = Color.Magenta;
            toolStripButton_choiceFieldOptions_newOption.Name = "toolStripButton_choiceFieldOptions_newOption";
            toolStripButton_choiceFieldOptions_newOption.Size = new Size(93, 24);
            toolStripButton_choiceFieldOptions_newOption.Text = "New Option";
            toolStripButton_choiceFieldOptions_newOption.Click += toolStripButton_choiceFieldOptions_newOption_Click;
            // 
            // toolStripButton_choiceFieldOptions_editSelectedOption
            // 
            toolStripButton_choiceFieldOptions_editSelectedOption.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_choiceFieldOptions_editSelectedOption.Enabled = false;
            toolStripButton_choiceFieldOptions_editSelectedOption.Image = (Image)resources.GetObject("toolStripButton_choiceFieldOptions_editSelectedOption.Image");
            toolStripButton_choiceFieldOptions_editSelectedOption.ImageTransparentColor = Color.Magenta;
            toolStripButton_choiceFieldOptions_editSelectedOption.Name = "toolStripButton_choiceFieldOptions_editSelectedOption";
            toolStripButton_choiceFieldOptions_editSelectedOption.Size = new Size(150, 24);
            toolStripButton_choiceFieldOptions_editSelectedOption.Text = "Edit Selected Option";
            toolStripButton_choiceFieldOptions_editSelectedOption.Click += toolStripButton_choiceFieldOptions_editSelectedOption_Click;
            // 
            // toolStripButton_choiceFieldOptions_deleteSelectedOption
            // 
            toolStripButton_choiceFieldOptions_deleteSelectedOption.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_choiceFieldOptions_deleteSelectedOption.Enabled = false;
            toolStripButton_choiceFieldOptions_deleteSelectedOption.ForeColor = Color.Red;
            toolStripButton_choiceFieldOptions_deleteSelectedOption.Image = (Image)resources.GetObject("toolStripButton_choiceFieldOptions_deleteSelectedOption.Image");
            toolStripButton_choiceFieldOptions_deleteSelectedOption.ImageTransparentColor = Color.Magenta;
            toolStripButton_choiceFieldOptions_deleteSelectedOption.Name = "toolStripButton_choiceFieldOptions_deleteSelectedOption";
            toolStripButton_choiceFieldOptions_deleteSelectedOption.Size = new Size(168, 24);
            toolStripButton_choiceFieldOptions_deleteSelectedOption.Text = "Delete Selected Option";
            toolStripButton_choiceFieldOptions_deleteSelectedOption.Click += toolStripButton_choiceFieldOptions_deleteSelectedOption_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox_required);
            groupBox1.Controls.Add(groupBox_outputVariable);
            groupBox1.Controls.Add(groupBox_defaultValue);
            groupBox1.Controls.Add(groupBox_label);
            groupBox1.Controls.Add(groupBox_type);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 537);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "About this Component";
            // 
            // groupBox_outputVariable
            // 
            groupBox_outputVariable.Controls.Add(textBox_outputVariable);
            groupBox_outputVariable.Dock = DockStyle.Top;
            groupBox_outputVariable.Location = new Point(3, 179);
            groupBox_outputVariable.Name = "groupBox_outputVariable";
            groupBox_outputVariable.Size = new Size(394, 52);
            groupBox_outputVariable.TabIndex = 4;
            groupBox_outputVariable.TabStop = false;
            groupBox_outputVariable.Text = "Output Variable";
            // 
            // textBox_outputVariable
            // 
            textBox_outputVariable.Dock = DockStyle.Fill;
            textBox_outputVariable.Location = new Point(3, 23);
            textBox_outputVariable.Name = "textBox_outputVariable";
            textBox_outputVariable.Size = new Size(388, 27);
            textBox_outputVariable.TabIndex = 1;
            textBox_outputVariable.TextChanged += textBox_outputVariable_TextChanged;
            // 
            // groupBox_defaultValue
            // 
            groupBox_defaultValue.Controls.Add(textBox_defaultValue);
            groupBox_defaultValue.Dock = DockStyle.Top;
            groupBox_defaultValue.Location = new Point(3, 127);
            groupBox_defaultValue.Name = "groupBox_defaultValue";
            groupBox_defaultValue.Size = new Size(394, 52);
            groupBox_defaultValue.TabIndex = 3;
            groupBox_defaultValue.TabStop = false;
            groupBox_defaultValue.Text = "Default Value";
            // 
            // textBox_defaultValue
            // 
            textBox_defaultValue.Dock = DockStyle.Fill;
            textBox_defaultValue.Location = new Point(3, 23);
            textBox_defaultValue.Name = "textBox_defaultValue";
            textBox_defaultValue.Size = new Size(388, 27);
            textBox_defaultValue.TabIndex = 1;
            textBox_defaultValue.TextChanged += textBox_defaultValue_TextChanged;
            // 
            // groupBox_label
            // 
            groupBox_label.Controls.Add(textBox_label);
            groupBox_label.Dock = DockStyle.Top;
            groupBox_label.Location = new Point(3, 75);
            groupBox_label.Name = "groupBox_label";
            groupBox_label.Size = new Size(394, 52);
            groupBox_label.TabIndex = 2;
            groupBox_label.TabStop = false;
            groupBox_label.Text = "Label";
            // 
            // textBox_label
            // 
            textBox_label.Dock = DockStyle.Fill;
            textBox_label.Location = new Point(3, 23);
            textBox_label.Name = "textBox_label";
            textBox_label.Size = new Size(388, 27);
            textBox_label.TabIndex = 1;
            textBox_label.TextChanged += textBox_label_TextChanged;
            // 
            // groupBox_type
            // 
            groupBox_type.Controls.Add(comboBox_type);
            groupBox_type.Dock = DockStyle.Top;
            groupBox_type.Location = new Point(3, 23);
            groupBox_type.Name = "groupBox_type";
            groupBox_type.Size = new Size(394, 52);
            groupBox_type.TabIndex = 1;
            groupBox_type.TabStop = false;
            groupBox_type.Text = "Type";
            // 
            // comboBox_type
            // 
            comboBox_type.Dock = DockStyle.Fill;
            comboBox_type.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_type.Enabled = false;
            comboBox_type.FormattingEnabled = true;
            comboBox_type.Location = new Point(3, 23);
            comboBox_type.Name = "comboBox_type";
            comboBox_type.Size = new Size(388, 28);
            comboBox_type.TabIndex = 0;
            // 
            // groupBox_required
            // 
            groupBox_required.Controls.Add(checkBox_required);
            groupBox_required.Dock = DockStyle.Top;
            groupBox_required.Location = new Point(3, 231);
            groupBox_required.Name = "groupBox_required";
            groupBox_required.Size = new Size(394, 52);
            groupBox_required.TabIndex = 5;
            groupBox_required.TabStop = false;
            groupBox_required.Text = "Required";
            // 
            // checkBox_required
            // 
            checkBox_required.AutoSize = true;
            checkBox_required.Dock = DockStyle.Fill;
            checkBox_required.Location = new Point(3, 23);
            checkBox_required.Name = "checkBox_required";
            checkBox_required.Size = new Size(388, 26);
            checkBox_required.TabIndex = 0;
            checkBox_required.UseVisualStyleBackColor = true;
            checkBox_required.CheckedChanged += checkBox_required_CheckedChanged;
            // 
            // FormPageComponentBuilder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 537);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormPageComponentBuilder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPageComponentBuilder";
            Load += FormPageComponentBuilder_Load;
            groupBox2.ResumeLayout(false);
            groupBox_choiceFieldOptions.ResumeLayout(false);
            groupBox_choiceFieldOptions.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox_outputVariable.ResumeLayout(false);
            groupBox_outputVariable.PerformLayout();
            groupBox_defaultValue.ResumeLayout(false);
            groupBox_defaultValue.PerformLayout();
            groupBox_label.ResumeLayout(false);
            groupBox_label.PerformLayout();
            groupBox_type.ResumeLayout(false);
            groupBox_required.ResumeLayout(false);
            groupBox_required.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox_outputVariable;
        private TextBox textBox_outputVariable;
        private GroupBox groupBox_defaultValue;
        private TextBox textBox_defaultValue;
        private GroupBox groupBox_label;
        private TextBox textBox_label;
        private GroupBox groupBox_type;
        private ComboBox comboBox_type;
        private GroupBox groupBox_choiceFieldOptions;
        private ListView listView_options;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton_choiceFieldOptions_newOption;
        private ToolStripButton toolStripButton_choiceFieldOptions_editSelectedOption;
        private ToolStripButton toolStripButton_choiceFieldOptions_deleteSelectedOption;
        private GroupBox groupBox_required;
        private CheckBox checkBox_required;
    }
}