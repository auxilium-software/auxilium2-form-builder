namespace Auxilium2FormBuilder.Forms
{
    partial class FormDefinitionBuilder
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            checkBox1 = new CheckBox();
            groupBox5 = new GroupBox();
            textBox_fileUUID = new TextBox();
            groupBox4 = new GroupBox();
            groupBox6 = new GroupBox();
            listView_pages = new ListView();
            groupBox7 = new GroupBox();
            listView_onSubmit = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 52);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Text Prefab Path";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(388, 27);
            textBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 562);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Options";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(3, 127);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(394, 52);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Is required?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Top;
            checkBox1.Location = new Point(3, 23);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(388, 17);
            checkBox1.TabIndex = 3;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox_fileUUID);
            groupBox5.Dock = DockStyle.Top;
            groupBox5.Location = new Point(3, 23);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(394, 52);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "ID";
            // 
            // textBox_fileUUID
            // 
            textBox_fileUUID.Dock = DockStyle.Fill;
            textBox_fileUUID.Location = new Point(3, 23);
            textBox_fileUUID.Name = "textBox_fileUUID";
            textBox_fileUUID.ReadOnly = true;
            textBox_fileUUID.Size = new Size(388, 27);
            textBox_fileUUID.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox7);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(400, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1171, 562);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Steps";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(listView_pages);
            groupBox6.Dock = DockStyle.Top;
            groupBox6.Location = new Point(3, 23);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1165, 235);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Page Definitions";
            // 
            // listView_pages
            // 
            listView_pages.Dock = DockStyle.Fill;
            listView_pages.FullRowSelect = true;
            listView_pages.Location = new Point(3, 23);
            listView_pages.MultiSelect = false;
            listView_pages.Name = "listView_pages";
            listView_pages.Size = new Size(1159, 209);
            listView_pages.TabIndex = 4;
            listView_pages.UseCompatibleStateImageBehavior = false;
            listView_pages.View = View.Details;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(listView_onSubmit);
            groupBox7.Dock = DockStyle.Top;
            groupBox7.Location = new Point(3, 258);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(1165, 235);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "On Submit...";
            // 
            // listView_onSubmit
            // 
            listView_onSubmit.Dock = DockStyle.Fill;
            listView_onSubmit.FullRowSelect = true;
            listView_onSubmit.Location = new Point(3, 23);
            listView_onSubmit.MultiSelect = false;
            listView_onSubmit.Name = "listView_onSubmit";
            listView_onSubmit.Size = new Size(1159, 209);
            listView_onSubmit.TabIndex = 4;
            listView_onSubmit.UseCompatibleStateImageBehavior = false;
            listView_onSubmit.View = View.Details;
            // 
            // FormDefinitionBuilder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 562);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Name = "FormDefinitionBuilder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDefinitionBuilder";
            WindowState = FormWindowState.Maximized;
            Load += FormDefinitionBuilder_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private CheckBox checkBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox textBox_fileUUID;
        private GroupBox groupBox7;
        private ListView listView_onSubmit;
        private GroupBox groupBox6;
        private ListView listView_pages;
    }
}