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
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox_outputVariable = new GroupBox();
            textBox_outputVariable = new TextBox();
            groupBox_defaultValue = new GroupBox();
            textBox_defaultValue = new TextBox();
            groupBox_label = new GroupBox();
            textBox_label = new TextBox();
            groupBox_type = new GroupBox();
            comboBox_type = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox_outputVariable.SuspendLayout();
            groupBox_defaultValue.SuspendLayout();
            groupBox_label.SuspendLayout();
            groupBox_type.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(400, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(763, 537);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Page Components";
            // 
            // groupBox1
            // 
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
            groupBox1.ResumeLayout(false);
            groupBox_outputVariable.ResumeLayout(false);
            groupBox_outputVariable.PerformLayout();
            groupBox_defaultValue.ResumeLayout(false);
            groupBox_defaultValue.PerformLayout();
            groupBox_label.ResumeLayout(false);
            groupBox_label.PerformLayout();
            groupBox_type.ResumeLayout(false);
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
    }
}