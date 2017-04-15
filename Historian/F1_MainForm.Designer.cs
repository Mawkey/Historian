namespace Historian
{
    partial class F1_MainForm
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
            this.ms_MainStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_History = new System.Windows.Forms.ListBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_SaveList = new System.Windows.Forms.Button();
            this.ms_MainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_MainStrip
            // 
            this.ms_MainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.ms_MainStrip.Location = new System.Drawing.Point(0, 0);
            this.ms_MainStrip.Name = "ms_MainStrip";
            this.ms_MainStrip.Size = new System.Drawing.Size(484, 24);
            this.ms_MainStrip.TabIndex = 1;
            this.ms_MainStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directoryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.directoryToolStripMenuItem.Text = "&Directory";
            this.directoryToolStripMenuItem.Click += new System.EventHandler(this.directoryToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItem2.Text = "&Settings";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Settings_Clicked);
            // 
            // lb_History
            // 
            this.lb_History.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_History.FormattingEnabled = true;
            this.lb_History.Location = new System.Drawing.Point(12, 27);
            this.lb_History.Name = "lb_History";
            this.lb_History.Size = new System.Drawing.Size(460, 394);
            this.lb_History.TabIndex = 2;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Update.Location = new System.Drawing.Point(13, 427);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update list";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_SaveList
            // 
            this.btn_SaveList.Location = new System.Drawing.Point(94, 427);
            this.btn_SaveList.Name = "btn_SaveList";
            this.btn_SaveList.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveList.TabIndex = 4;
            this.btn_SaveList.Text = "Save list";
            this.btn_SaveList.UseVisualStyleBackColor = true;
            this.btn_SaveList.Click += new System.EventHandler(this.btn_SaveList_Click);
            // 
            // F1_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.btn_SaveList);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lb_History);
            this.Controls.Add(this.ms_MainStrip);
            this.MainMenuStrip = this.ms_MainStrip;
            this.Name = "F1_MainForm";
            this.Text = "Historian";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnApp_Exit);
            this.Load += new System.EventHandler(this.F1_MainForm_Load);
            this.ms_MainStrip.ResumeLayout(false);
            this.ms_MainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip ms_MainStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ListBox lb_History;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_SaveList;
    }
}

