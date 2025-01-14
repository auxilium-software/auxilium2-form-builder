namespace Auxilium2FormBuilder.Forms
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            listView1 = new ListView();
            toolStrip_main = new ToolStrip();
            toolStrip_main__dropDownButton_file = new ToolStripDropDownButton();
            toolStrip_main__dropDownButton_file__toolStripMenuItem_newFormDefinition = new ToolStripMenuItem();
            toolStrip_main__dropDownButton_file__toolStripMenuItem_exit = new ToolStripMenuItem();
            toolStrip_main__dropDownButton_settings = new ToolStripDropDownButton();
            toolStrip_main__dropDownButton_file__toolStripMenuItem_setFormDirectory = new ToolStripMenuItem();
            toolStrip_main.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(0, 27);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(1036, 423);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += this.listView1_DoubleClick;
            // 
            // toolStrip_main
            // 
            toolStrip_main.ImageScalingSize = new Size(20, 20);
            toolStrip_main.Items.AddRange(new ToolStripItem[] { toolStrip_main__dropDownButton_file, toolStrip_main__dropDownButton_settings });
            toolStrip_main.Location = new Point(0, 0);
            toolStrip_main.Name = "toolStrip_main";
            toolStrip_main.Size = new Size(1036, 27);
            toolStrip_main.TabIndex = 1;
            toolStrip_main.Text = "toolStrip1";
            // 
            // toolStrip_main__dropDownButton_file
            // 
            toolStrip_main__dropDownButton_file.DropDownItems.AddRange(new ToolStripItem[] { toolStrip_main__dropDownButton_file__toolStripMenuItem_newFormDefinition, toolStrip_main__dropDownButton_file__toolStripMenuItem_exit });
            toolStrip_main__dropDownButton_file.Image = (Image)resources.GetObject("toolStrip_main__dropDownButton_file.Image");
            toolStrip_main__dropDownButton_file.ImageTransparentColor = Color.Magenta;
            toolStrip_main__dropDownButton_file.Name = "toolStrip_main__dropDownButton_file";
            toolStrip_main__dropDownButton_file.Size = new Size(66, 24);
            toolStrip_main__dropDownButton_file.Text = "File";
            toolStrip_main__dropDownButton_file.ToolTipText = "File";
            // 
            // toolStrip_main__dropDownButton_file__toolStripMenuItem_newFormDefinition
            // 
            toolStrip_main__dropDownButton_file__toolStripMenuItem_newFormDefinition.Enabled = false;
            toolStrip_main__dropDownButton_file__toolStripMenuItem_newFormDefinition.Name = "toolStrip_main__dropDownButton_file__toolStripMenuItem_newFormDefinition";
            toolStrip_main__dropDownButton_file__toolStripMenuItem_newFormDefinition.Size = new Size(230, 26);
            toolStrip_main__dropDownButton_file__toolStripMenuItem_newFormDefinition.Text = "New Form Definition";
            // 
            // toolStrip_main__dropDownButton_file__toolStripMenuItem_exit
            // 
            toolStrip_main__dropDownButton_file__toolStripMenuItem_exit.Name = "toolStrip_main__dropDownButton_file__toolStripMenuItem_exit";
            toolStrip_main__dropDownButton_file__toolStripMenuItem_exit.Size = new Size(230, 26);
            toolStrip_main__dropDownButton_file__toolStripMenuItem_exit.Text = "Exit";
            toolStrip_main__dropDownButton_file__toolStripMenuItem_exit.Click += toolStrip_main__dropDownButton_file__toolStripMenuItem_exit_Click;
            // 
            // toolStrip_main__dropDownButton_settings
            // 
            toolStrip_main__dropDownButton_settings.DropDownItems.AddRange(new ToolStripItem[] { toolStrip_main__dropDownButton_file__toolStripMenuItem_setFormDirectory });
            toolStrip_main__dropDownButton_settings.Image = (Image)resources.GetObject("toolStrip_main__dropDownButton_settings.Image");
            toolStrip_main__dropDownButton_settings.ImageTransparentColor = Color.Magenta;
            toolStrip_main__dropDownButton_settings.Name = "toolStrip_main__dropDownButton_settings";
            toolStrip_main__dropDownButton_settings.Size = new Size(96, 24);
            toolStrip_main__dropDownButton_settings.Text = "Settings";
            // 
            // toolStrip_main__dropDownButton_file__toolStripMenuItem_setFormDirectory
            // 
            toolStrip_main__dropDownButton_file__toolStripMenuItem_setFormDirectory.Name = "toolStrip_main__dropDownButton_file__toolStripMenuItem_setFormDirectory";
            toolStrip_main__dropDownButton_file__toolStripMenuItem_setFormDirectory.Size = new Size(216, 26);
            toolStrip_main__dropDownButton_file__toolStripMenuItem_setFormDirectory.Text = "Set Form Directory";
            toolStrip_main__dropDownButton_file__toolStripMenuItem_setFormDirectory.Click += toolStrip_main__dropDownButton_file__toolStripMenuItem_setFormDirectory_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 450);
            Controls.Add(listView1);
            Controls.Add(toolStrip_main);
            Name = "MainMenu";
            Text = "MainMenu";
            toolStrip_main.ResumeLayout(false);
            toolStrip_main.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ToolStrip toolStrip_main;
        private ToolStripDropDownButton toolStrip_main__dropDownButton_file;
        private ToolStripMenuItem toolStrip_main__dropDownButton_file__toolStripMenuItem_newFormDefinition;
        private ToolStripMenuItem toolStrip_main__dropDownButton_file__toolStripMenuItem_exit;
        private ToolStripDropDownButton toolStrip_main__dropDownButton_settings;
        private ToolStripMenuItem toolStrip_main__dropDownButton_file__toolStripMenuItem_setFormDirectory;
    }
}