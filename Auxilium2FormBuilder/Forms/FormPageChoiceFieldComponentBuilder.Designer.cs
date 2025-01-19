namespace Auxilium2FormBuilder.Forms
{
    partial class FormPageChoiceFieldComponentBuilder
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
            button_modify = new Button();
            groupBox_strongLabel = new GroupBox();
            textBox_strongLabel = new TextBox();
            button_strongLabel = new Button();
            groupBox_secondaryLabel = new GroupBox();
            textBox_secondaryLabel = new TextBox();
            button_secondaryLabel = new Button();
            groupBox_value = new GroupBox();
            textBox_value = new TextBox();
            groupBox_strongLabel.SuspendLayout();
            groupBox_secondaryLabel.SuspendLayout();
            groupBox_value.SuspendLayout();
            SuspendLayout();
            // 
            // button_modify
            // 
            button_modify.Dock = DockStyle.Bottom;
            button_modify.Location = new Point(0, 167);
            button_modify.Name = "button_modify";
            button_modify.Size = new Size(323, 30);
            button_modify.TabIndex = 3;
            button_modify.Text = "Modify";
            button_modify.UseVisualStyleBackColor = true;
            button_modify.Click += button_modify_Click;
            // 
            // groupBox_strongLabel
            // 
            groupBox_strongLabel.Controls.Add(textBox_strongLabel);
            groupBox_strongLabel.Controls.Add(button_strongLabel);
            groupBox_strongLabel.Dock = DockStyle.Top;
            groupBox_strongLabel.Location = new Point(0, 0);
            groupBox_strongLabel.Name = "groupBox_strongLabel";
            groupBox_strongLabel.Size = new Size(323, 52);
            groupBox_strongLabel.TabIndex = 4;
            groupBox_strongLabel.TabStop = false;
            groupBox_strongLabel.Text = "Label";
            // 
            // textBox_strongLabel
            // 
            textBox_strongLabel.Dock = DockStyle.Fill;
            textBox_strongLabel.Location = new Point(3, 23);
            textBox_strongLabel.Name = "textBox_strongLabel";
            textBox_strongLabel.ReadOnly = true;
            textBox_strongLabel.Size = new Size(257, 27);
            textBox_strongLabel.TabIndex = 1;
            textBox_strongLabel.TextChanged += textBox_strongLabel_TextChanged;
            // 
            // button_strongLabel
            // 
            button_strongLabel.Dock = DockStyle.Right;
            button_strongLabel.Location = new Point(260, 23);
            button_strongLabel.Name = "button_strongLabel";
            button_strongLabel.Size = new Size(60, 26);
            button_strongLabel.TabIndex = 2;
            button_strongLabel.Text = "select";
            button_strongLabel.UseVisualStyleBackColor = true;
            button_strongLabel.Click += button_strongLabel_Click;
            // 
            // groupBox_secondaryLabel
            // 
            groupBox_secondaryLabel.Controls.Add(textBox_secondaryLabel);
            groupBox_secondaryLabel.Controls.Add(button_secondaryLabel);
            groupBox_secondaryLabel.Dock = DockStyle.Top;
            groupBox_secondaryLabel.Location = new Point(0, 52);
            groupBox_secondaryLabel.Name = "groupBox_secondaryLabel";
            groupBox_secondaryLabel.Size = new Size(323, 52);
            groupBox_secondaryLabel.TabIndex = 5;
            groupBox_secondaryLabel.TabStop = false;
            groupBox_secondaryLabel.Text = "Secondary Label";
            // 
            // textBox_secondaryLabel
            // 
            textBox_secondaryLabel.Dock = DockStyle.Fill;
            textBox_secondaryLabel.Location = new Point(3, 23);
            textBox_secondaryLabel.Name = "textBox_secondaryLabel";
            textBox_secondaryLabel.ReadOnly = true;
            textBox_secondaryLabel.Size = new Size(257, 27);
            textBox_secondaryLabel.TabIndex = 1;
            textBox_secondaryLabel.TextChanged += textBox_secondaryLabel_TextChanged;
            // 
            // button_secondaryLabel
            // 
            button_secondaryLabel.Dock = DockStyle.Right;
            button_secondaryLabel.Location = new Point(260, 23);
            button_secondaryLabel.Name = "button_secondaryLabel";
            button_secondaryLabel.Size = new Size(60, 26);
            button_secondaryLabel.TabIndex = 3;
            button_secondaryLabel.Text = "select";
            button_secondaryLabel.UseVisualStyleBackColor = true;
            button_secondaryLabel.Click += button_secondaryLabel_Click;
            // 
            // groupBox_value
            // 
            groupBox_value.Controls.Add(textBox_value);
            groupBox_value.Dock = DockStyle.Top;
            groupBox_value.Location = new Point(0, 104);
            groupBox_value.Name = "groupBox_value";
            groupBox_value.Size = new Size(323, 52);
            groupBox_value.TabIndex = 6;
            groupBox_value.TabStop = false;
            groupBox_value.Text = "Value";
            // 
            // textBox_value
            // 
            textBox_value.Dock = DockStyle.Fill;
            textBox_value.Location = new Point(3, 23);
            textBox_value.Name = "textBox_value";
            textBox_value.ReadOnly = true;
            textBox_value.Size = new Size(317, 27);
            textBox_value.TabIndex = 1;
            textBox_value.TextChanged += textBox_value_TextChanged;
            // 
            // FormPageChoiceFieldComponentBuilder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 197);
            Controls.Add(groupBox_value);
            Controls.Add(groupBox_secondaryLabel);
            Controls.Add(groupBox_strongLabel);
            Controls.Add(button_modify);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormPageChoiceFieldComponentBuilder";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormPageChoiceFieldComponentBuilder";
            Load += FormPageChoiceFieldComponentBuilder_Load;
            groupBox_strongLabel.ResumeLayout(false);
            groupBox_strongLabel.PerformLayout();
            groupBox_secondaryLabel.ResumeLayout(false);
            groupBox_secondaryLabel.PerformLayout();
            groupBox_value.ResumeLayout(false);
            groupBox_value.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_modify;
        private GroupBox groupBox_strongLabel;
        private TextBox textBox_strongLabel;
        private GroupBox groupBox_secondaryLabel;
        private TextBox textBox_secondaryLabel;
        private GroupBox groupBox_value;
        private TextBox textBox_value;
        private Button button_strongLabel;
        private Button button_secondaryLabel;
    }
}