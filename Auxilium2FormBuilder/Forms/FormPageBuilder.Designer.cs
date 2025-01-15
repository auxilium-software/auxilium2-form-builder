namespace Auxilium2FormBuilder.Forms
{
    partial class FormPageBuilder
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
            groupBox_pageIfStatement = new GroupBox();
            textBox_ifStatement = new TextBox();
            groupBox_pageDescription = new GroupBox();
            textBox_description = new TextBox();
            groupBox_pageTitle = new GroupBox();
            textBox_title = new TextBox();
            groupBox_pageID = new GroupBox();
            textBox_pageID = new TextBox();
            groupBox2 = new GroupBox();
            listView_pageComponents = new ListView();
            groupBox1.SuspendLayout();
            groupBox_pageIfStatement.SuspendLayout();
            groupBox_pageDescription.SuspendLayout();
            groupBox_pageTitle.SuspendLayout();
            groupBox_pageID.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox_pageIfStatement);
            groupBox1.Controls.Add(groupBox_pageDescription);
            groupBox1.Controls.Add(groupBox_pageTitle);
            groupBox1.Controls.Add(groupBox_pageID);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 453);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "About the Page";
            // 
            // groupBox_pageIfStatement
            // 
            groupBox_pageIfStatement.Controls.Add(textBox_ifStatement);
            groupBox_pageIfStatement.Dock = DockStyle.Top;
            groupBox_pageIfStatement.Location = new Point(3, 179);
            groupBox_pageIfStatement.Name = "groupBox_pageIfStatement";
            groupBox_pageIfStatement.Size = new Size(244, 52);
            groupBox_pageIfStatement.TabIndex = 4;
            groupBox_pageIfStatement.TabStop = false;
            groupBox_pageIfStatement.Text = "If Statement";
            // 
            // textBox_ifStatement
            // 
            textBox_ifStatement.Dock = DockStyle.Fill;
            textBox_ifStatement.Location = new Point(3, 23);
            textBox_ifStatement.Name = "textBox_ifStatement";
            textBox_ifStatement.Size = new Size(238, 27);
            textBox_ifStatement.TabIndex = 1;
            // 
            // groupBox_pageDescription
            // 
            groupBox_pageDescription.Controls.Add(textBox_description);
            groupBox_pageDescription.Dock = DockStyle.Top;
            groupBox_pageDescription.Location = new Point(3, 127);
            groupBox_pageDescription.Name = "groupBox_pageDescription";
            groupBox_pageDescription.Size = new Size(244, 52);
            groupBox_pageDescription.TabIndex = 3;
            groupBox_pageDescription.TabStop = false;
            groupBox_pageDescription.Text = "Description";
            // 
            // textBox_description
            // 
            textBox_description.Dock = DockStyle.Fill;
            textBox_description.Location = new Point(3, 23);
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(238, 27);
            textBox_description.TabIndex = 1;
            // 
            // groupBox_pageTitle
            // 
            groupBox_pageTitle.Controls.Add(textBox_title);
            groupBox_pageTitle.Dock = DockStyle.Top;
            groupBox_pageTitle.Location = new Point(3, 75);
            groupBox_pageTitle.Name = "groupBox_pageTitle";
            groupBox_pageTitle.Size = new Size(244, 52);
            groupBox_pageTitle.TabIndex = 2;
            groupBox_pageTitle.TabStop = false;
            groupBox_pageTitle.Text = "Title";
            // 
            // textBox_title
            // 
            textBox_title.Dock = DockStyle.Fill;
            textBox_title.Location = new Point(3, 23);
            textBox_title.Name = "textBox_title";
            textBox_title.Size = new Size(238, 27);
            textBox_title.TabIndex = 1;
            // 
            // groupBox_pageID
            // 
            groupBox_pageID.Controls.Add(textBox_pageID);
            groupBox_pageID.Dock = DockStyle.Top;
            groupBox_pageID.Location = new Point(3, 23);
            groupBox_pageID.Name = "groupBox_pageID";
            groupBox_pageID.Size = new Size(244, 52);
            groupBox_pageID.TabIndex = 1;
            groupBox_pageID.TabStop = false;
            groupBox_pageID.Text = "ID";
            // 
            // textBox_pageID
            // 
            textBox_pageID.Dock = DockStyle.Fill;
            textBox_pageID.Location = new Point(3, 23);
            textBox_pageID.Name = "textBox_pageID";
            textBox_pageID.Size = new Size(238, 27);
            textBox_pageID.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView_pageComponents);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(250, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1232, 453);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Page Components";
            // 
            // listView_pageComponents
            // 
            listView_pageComponents.Dock = DockStyle.Fill;
            listView_pageComponents.FullRowSelect = true;
            listView_pageComponents.Location = new Point(3, 23);
            listView_pageComponents.MultiSelect = false;
            listView_pageComponents.Name = "listView_pageComponents";
            listView_pageComponents.Size = new Size(1226, 427);
            listView_pageComponents.TabIndex = 4;
            listView_pageComponents.UseCompatibleStateImageBehavior = false;
            listView_pageComponents.View = View.Details;
            // 
            // FormPageBuilder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 453);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormPageBuilder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPageBuilder";
            Load += FormPageBuilder_Load;
            groupBox1.ResumeLayout(false);
            groupBox_pageIfStatement.ResumeLayout(false);
            groupBox_pageIfStatement.PerformLayout();
            groupBox_pageDescription.ResumeLayout(false);
            groupBox_pageDescription.PerformLayout();
            groupBox_pageTitle.ResumeLayout(false);
            groupBox_pageTitle.PerformLayout();
            groupBox_pageID.ResumeLayout(false);
            groupBox_pageID.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox_pageIfStatement;
        private TextBox textBox_ifStatement;
        private GroupBox groupBox_pageDescription;
        private TextBox textBox_description;
        private GroupBox groupBox_pageTitle;
        private TextBox textBox_title;
        private GroupBox groupBox_pageID;
        private TextBox textBox_pageID;
        private ListView listView_pageComponents;
    }
}