namespace DataMine
{
    partial class DataMine
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doThingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeTheGlobalVectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainBox = new System.Windows.Forms.TextBox();
            this.secondaryBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.executeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1066, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPathToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.filesToolStripMenuItem.Text = "Files";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // openPathToolStripMenuItem
            // 
            this.openPathToolStripMenuItem.Name = "openPathToolStripMenuItem";
            this.openPathToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.openPathToolStripMenuItem.Text = "Open Path...";
            this.openPathToolStripMenuItem.Click += new System.EventHandler(this.openPathToolStripMenuItem_Click);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doThingsToolStripMenuItem,
            this.seeTheGlobalVectorToolStripMenuItem});
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.executeToolStripMenuItem.Text = "Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.executeToolStripMenuItem_Click);
            // 
            // doThingsToolStripMenuItem
            // 
            this.doThingsToolStripMenuItem.Name = "doThingsToolStripMenuItem";
            this.doThingsToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.doThingsToolStripMenuItem.Text = "Do Things";
            this.doThingsToolStripMenuItem.Click += new System.EventHandler(this.doThingsToolStripMenuItem_Click);
            // 
            // seeTheGlobalVectorToolStripMenuItem
            // 
            this.seeTheGlobalVectorToolStripMenuItem.Name = "seeTheGlobalVectorToolStripMenuItem";
            this.seeTheGlobalVectorToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.seeTheGlobalVectorToolStripMenuItem.Text = "See The Global Vector";
            this.seeTheGlobalVectorToolStripMenuItem.Click += new System.EventHandler(this.seeTheGlobalVectorToolStripMenuItem_Click);
            // 
            // mainBox
            // 
            this.mainBox.Location = new System.Drawing.Point(14, 36);
            this.mainBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainBox.Multiline = true;
            this.mainBox.Name = "mainBox";
            this.mainBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainBox.Size = new System.Drawing.Size(465, 547);
            this.mainBox.TabIndex = 1;
            this.mainBox.TextChanged += new System.EventHandler(this.mainBox_TextChanged);
            // 
            // secondaryBox
            // 
            this.secondaryBox.Location = new System.Drawing.Point(486, 36);
            this.secondaryBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secondaryBox.Multiline = true;
            this.secondaryBox.Name = "secondaryBox";
            this.secondaryBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.secondaryBox.Size = new System.Drawing.Size(566, 547);
            this.secondaryBox.TabIndex = 2;
            // 
            // DataMine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 600);
            this.Controls.Add(this.secondaryBox);
            this.Controls.Add(this.mainBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DataMine";
            this.Text = "DataMine";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem openPathToolStripMenuItem;
        private ToolStripMenuItem executeToolStripMenuItem;
        private TextBox mainBox;
        private TextBox secondaryBox;
        private ToolStripMenuItem doThingsToolStripMenuItem;
        private ToolStripMenuItem seeTheGlobalVectorToolStripMenuItem;
    }
}