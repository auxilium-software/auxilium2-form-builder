namespace Auxilium2FormBuilder.Forms
{
    partial class NewFormPageComponentTypeSelector
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
            radioButton_textField = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton_radioButtonField = new RadioButton();
            radioButton_largeTextField = new RadioButton();
            button_create = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton_textField
            // 
            radioButton_textField.AutoSize = true;
            radioButton_textField.Dock = DockStyle.Top;
            radioButton_textField.Location = new Point(3, 23);
            radioButton_textField.Name = "radioButton_textField";
            radioButton_textField.Size = new Size(260, 24);
            radioButton_textField.TabIndex = 0;
            radioButton_textField.TabStop = true;
            radioButton_textField.Text = "Text Field";
            radioButton_textField.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton_radioButtonField);
            groupBox1.Controls.Add(radioButton_largeTextField);
            groupBox1.Controls.Add(radioButton_textField);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 114);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "FieldType";
            // 
            // radioButton_radioButtonField
            // 
            radioButton_radioButtonField.AutoSize = true;
            radioButton_radioButtonField.Dock = DockStyle.Top;
            radioButton_radioButtonField.Location = new Point(3, 71);
            radioButton_radioButtonField.Name = "radioButton_radioButtonField";
            radioButton_radioButtonField.Size = new Size(260, 24);
            radioButton_radioButtonField.TabIndex = 1;
            radioButton_radioButtonField.TabStop = true;
            radioButton_radioButtonField.Text = "Radio Button Field";
            radioButton_radioButtonField.UseVisualStyleBackColor = true;
            // 
            // radioButton_largeTextField
            // 
            radioButton_largeTextField.AutoSize = true;
            radioButton_largeTextField.Dock = DockStyle.Top;
            radioButton_largeTextField.Location = new Point(3, 47);
            radioButton_largeTextField.Name = "radioButton_largeTextField";
            radioButton_largeTextField.Size = new Size(260, 24);
            radioButton_largeTextField.TabIndex = 2;
            radioButton_largeTextField.TabStop = true;
            radioButton_largeTextField.Text = "Large Text Field";
            radioButton_largeTextField.UseVisualStyleBackColor = true;
            // 
            // button_create
            // 
            button_create.Dock = DockStyle.Bottom;
            button_create.Location = new Point(0, 114);
            button_create.Name = "button_create";
            button_create.Size = new Size(266, 30);
            button_create.TabIndex = 2;
            button_create.Text = "Create";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // NewFormPageComponentTypeSelector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 144);
            Controls.Add(groupBox1);
            Controls.Add(button_create);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NewFormPageComponentTypeSelector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Component Selector";
            Load += NewFormPageComponentTypeSelector_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radioButton_textField;
        private GroupBox groupBox1;
        private RadioButton radioButton_radioButtonField;
        private RadioButton radioButton_largeTextField;
        private Button button_create;
    }
}