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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDefinitionBuilder));
            groupBox1 = new GroupBox();
            textBox_textPrefabPath = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            checkBox_shouldFinalReview = new CheckBox();
            groupBox5 = new GroupBox();
            textBox_fileUUID = new TextBox();
            groupBox4 = new GroupBox();
            groupBox7 = new GroupBox();
            listView_onSubmit = new ListView();
            toolStrip2 = new ToolStrip();
            toolStripButton_submitSteps_newStep = new ToolStripButton();
            toolStripButton_submitSteps_editSelectedStep = new ToolStripButton();
            toolStripButton_submitSteps_deleteSelectedStep = new ToolStripButton();
            groupBox_finalReviewSteps = new GroupBox();
            listView1 = new ListView();
            toolStrip3 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            groupBox6 = new GroupBox();
            listView_pages = new ListView();
            toolStrip1 = new ToolStrip();
            toolStripButton_pageDefinitions_newPage = new ToolStripButton();
            toolStripButton_pageDefinitions_editSelectedPage = new ToolStripButton();
            toolStripButton_pageDefinitions_deleteSelectedPage = new ToolStripButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox7.SuspendLayout();
            toolStrip2.SuspendLayout();
            groupBox_finalReviewSteps.SuspendLayout();
            toolStrip3.SuspendLayout();
            groupBox6.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_textPrefabPath);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 52);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Text Prefab Path";
            // 
            // textBox_textPrefabPath
            // 
            textBox_textPrefabPath.Dock = DockStyle.Fill;
            textBox_textPrefabPath.Location = new Point(3, 23);
            textBox_textPrefabPath.Name = "textBox_textPrefabPath";
            textBox_textPrefabPath.Size = new Size(388, 27);
            textBox_textPrefabPath.TabIndex = 1;
            textBox_textPrefabPath.TextChanged += textBox_textPrefabPath_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 792);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Options";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox_shouldFinalReview);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(3, 127);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(394, 52);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Final Review?";
            // 
            // checkBox_shouldFinalReview
            // 
            checkBox_shouldFinalReview.AutoSize = true;
            checkBox_shouldFinalReview.Dock = DockStyle.Top;
            checkBox_shouldFinalReview.Location = new Point(3, 23);
            checkBox_shouldFinalReview.Name = "checkBox_shouldFinalReview";
            checkBox_shouldFinalReview.Size = new Size(388, 17);
            checkBox_shouldFinalReview.TabIndex = 3;
            checkBox_shouldFinalReview.UseVisualStyleBackColor = true;
            checkBox_shouldFinalReview.CheckedChanged += checkBox_shouldFinalReview_CheckedChanged;
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
            groupBox4.Controls.Add(groupBox_finalReviewSteps);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(400, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1171, 792);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Steps";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(listView_onSubmit);
            groupBox7.Controls.Add(toolStrip2);
            groupBox7.Dock = DockStyle.Top;
            groupBox7.Location = new Point(3, 523);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(1165, 250);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "On Submit...";
            // 
            // listView_onSubmit
            // 
            listView_onSubmit.Dock = DockStyle.Fill;
            listView_onSubmit.FullRowSelect = true;
            listView_onSubmit.Location = new Point(3, 50);
            listView_onSubmit.MultiSelect = false;
            listView_onSubmit.Name = "listView_onSubmit";
            listView_onSubmit.Size = new Size(1159, 197);
            listView_onSubmit.TabIndex = 4;
            listView_onSubmit.UseCompatibleStateImageBehavior = false;
            listView_onSubmit.View = View.Details;
            listView_onSubmit.SelectedIndexChanged += listView_onSubmit_SelectedIndexChanged;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripButton_submitSteps_newStep, toolStripButton_submitSteps_editSelectedStep, toolStripButton_submitSteps_deleteSelectedStep });
            toolStrip2.Location = new Point(3, 23);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1159, 27);
            toolStrip2.TabIndex = 6;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton_submitSteps_newStep
            // 
            toolStripButton_submitSteps_newStep.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_submitSteps_newStep.Image = (Image)resources.GetObject("toolStripButton_submitSteps_newStep.Image");
            toolStripButton_submitSteps_newStep.ImageTransparentColor = Color.Magenta;
            toolStripButton_submitSteps_newStep.Name = "toolStripButton_submitSteps_newStep";
            toolStripButton_submitSteps_newStep.Size = new Size(77, 24);
            toolStripButton_submitSteps_newStep.Text = "New Step";
            // 
            // toolStripButton_submitSteps_editSelectedStep
            // 
            toolStripButton_submitSteps_editSelectedStep.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_submitSteps_editSelectedStep.Enabled = false;
            toolStripButton_submitSteps_editSelectedStep.Image = (Image)resources.GetObject("toolStripButton_submitSteps_editSelectedStep.Image");
            toolStripButton_submitSteps_editSelectedStep.ImageTransparentColor = Color.Magenta;
            toolStripButton_submitSteps_editSelectedStep.Name = "toolStripButton_submitSteps_editSelectedStep";
            toolStripButton_submitSteps_editSelectedStep.Size = new Size(134, 24);
            toolStripButton_submitSteps_editSelectedStep.Text = "Edit Selected Step";
            // 
            // toolStripButton_submitSteps_deleteSelectedStep
            // 
            toolStripButton_submitSteps_deleteSelectedStep.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_submitSteps_deleteSelectedStep.Enabled = false;
            toolStripButton_submitSteps_deleteSelectedStep.ForeColor = Color.Red;
            toolStripButton_submitSteps_deleteSelectedStep.Image = (Image)resources.GetObject("toolStripButton_submitSteps_deleteSelectedStep.Image");
            toolStripButton_submitSteps_deleteSelectedStep.ImageTransparentColor = Color.Magenta;
            toolStripButton_submitSteps_deleteSelectedStep.Name = "toolStripButton_submitSteps_deleteSelectedStep";
            toolStripButton_submitSteps_deleteSelectedStep.Size = new Size(152, 24);
            toolStripButton_submitSteps_deleteSelectedStep.Text = "Delete Selected Step";
            // 
            // groupBox_finalReviewSteps
            // 
            groupBox_finalReviewSteps.Controls.Add(listView1);
            groupBox_finalReviewSteps.Controls.Add(toolStrip3);
            groupBox_finalReviewSteps.Dock = DockStyle.Top;
            groupBox_finalReviewSteps.Enabled = false;
            groupBox_finalReviewSteps.Location = new Point(3, 273);
            groupBox_finalReviewSteps.Name = "groupBox_finalReviewSteps";
            groupBox_finalReviewSteps.Size = new Size(1165, 250);
            groupBox_finalReviewSteps.TabIndex = 5;
            groupBox_finalReviewSteps.TabStop = false;
            groupBox_finalReviewSteps.Text = "Final Review Steps...";
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(3, 50);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(1159, 197);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // toolStrip3
            // 
            toolStrip3.ImageScalingSize = new Size(20, 20);
            toolStrip3.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip3.Location = new Point(3, 23);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(1159, 27);
            toolStrip3.TabIndex = 6;
            toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(77, 24);
            toolStripButton1.Text = "New Step";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Enabled = false;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(134, 24);
            toolStripButton2.Text = "Edit Selected Step";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Enabled = false;
            toolStripButton3.ForeColor = Color.Red;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(152, 24);
            toolStripButton3.Text = "Delete Selected Step";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(listView_pages);
            groupBox6.Controls.Add(toolStrip1);
            groupBox6.Dock = DockStyle.Top;
            groupBox6.Location = new Point(3, 23);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1165, 250);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Page Definitions";
            // 
            // listView_pages
            // 
            listView_pages.Dock = DockStyle.Fill;
            listView_pages.FullRowSelect = true;
            listView_pages.Location = new Point(3, 50);
            listView_pages.MultiSelect = false;
            listView_pages.Name = "listView_pages";
            listView_pages.Size = new Size(1159, 197);
            listView_pages.TabIndex = 4;
            listView_pages.UseCompatibleStateImageBehavior = false;
            listView_pages.View = View.Details;
            listView_pages.SelectedIndexChanged += listView_pages_SelectedIndexChanged;
            listView_pages.DoubleClick += listView_pages_DoubleClick;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton_pageDefinitions_newPage, toolStripButton_pageDefinitions_editSelectedPage, toolStripButton_pageDefinitions_deleteSelectedPage });
            toolStrip1.Location = new Point(3, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1159, 27);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_pageDefinitions_newPage
            // 
            toolStripButton_pageDefinitions_newPage.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_pageDefinitions_newPage.Image = (Image)resources.GetObject("toolStripButton_pageDefinitions_newPage.Image");
            toolStripButton_pageDefinitions_newPage.ImageTransparentColor = Color.Magenta;
            toolStripButton_pageDefinitions_newPage.Name = "toolStripButton_pageDefinitions_newPage";
            toolStripButton_pageDefinitions_newPage.Size = new Size(79, 24);
            toolStripButton_pageDefinitions_newPage.Text = "New Page";
            toolStripButton_pageDefinitions_newPage.Click += toolStripButton_pageDefinitions_newPage_Click;
            // 
            // toolStripButton_pageDefinitions_editSelectedPage
            // 
            toolStripButton_pageDefinitions_editSelectedPage.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_pageDefinitions_editSelectedPage.Enabled = false;
            toolStripButton_pageDefinitions_editSelectedPage.Image = (Image)resources.GetObject("toolStripButton_pageDefinitions_editSelectedPage.Image");
            toolStripButton_pageDefinitions_editSelectedPage.ImageTransparentColor = Color.Magenta;
            toolStripButton_pageDefinitions_editSelectedPage.Name = "toolStripButton_pageDefinitions_editSelectedPage";
            toolStripButton_pageDefinitions_editSelectedPage.Size = new Size(136, 24);
            toolStripButton_pageDefinitions_editSelectedPage.Text = "Edit Selected Page";
            // 
            // toolStripButton_pageDefinitions_deleteSelectedPage
            // 
            toolStripButton_pageDefinitions_deleteSelectedPage.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_pageDefinitions_deleteSelectedPage.Enabled = false;
            toolStripButton_pageDefinitions_deleteSelectedPage.ForeColor = Color.Red;
            toolStripButton_pageDefinitions_deleteSelectedPage.Image = (Image)resources.GetObject("toolStripButton_pageDefinitions_deleteSelectedPage.Image");
            toolStripButton_pageDefinitions_deleteSelectedPage.ImageTransparentColor = Color.Magenta;
            toolStripButton_pageDefinitions_deleteSelectedPage.Name = "toolStripButton_pageDefinitions_deleteSelectedPage";
            toolStripButton_pageDefinitions_deleteSelectedPage.Size = new Size(154, 24);
            toolStripButton_pageDefinitions_deleteSelectedPage.Text = "Delete Selected Page";
            // 
            // FormDefinitionBuilder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 792);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Name = "FormDefinitionBuilder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDefinitionBuilder";
            Load += FormDefinitionBuilder_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            groupBox_finalReviewSteps.ResumeLayout(false);
            groupBox_finalReviewSteps.PerformLayout();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox_textPrefabPath;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private CheckBox checkBox_shouldFinalReview;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox textBox_fileUUID;
        private GroupBox groupBox7;
        private ListView listView_onSubmit;
        private GroupBox groupBox6;
        private ListView listView_pages;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripButton_submitSteps_newStep;
        private ToolStripButton toolStripButton_submitSteps_editSelectedStep;
        private ToolStripButton toolStripButton_submitSteps_deleteSelectedStep;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton_pageDefinitions_newPage;
        private ToolStripButton toolStripButton_pageDefinitions_editSelectedPage;
        private ToolStripButton toolStripButton_pageDefinitions_deleteSelectedPage;
        private GroupBox groupBox_finalReviewSteps;
        private ListView listView1;
        private ToolStrip toolStrip3;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
    }
}