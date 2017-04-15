namespace Historian
{
    partial class F2_Settings
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
            this.btn_ChangeFolder = new System.Windows.Forms.Button();
            this.tb_Directory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lb_SettingsSaved = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ChangeFolder
            // 
            this.btn_ChangeFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChangeFolder.Location = new System.Drawing.Point(447, 28);
            this.btn_ChangeFolder.Name = "btn_ChangeFolder";
            this.btn_ChangeFolder.Size = new System.Drawing.Size(24, 20);
            this.btn_ChangeFolder.TabIndex = 0;
            this.btn_ChangeFolder.Text = "...";
            this.btn_ChangeFolder.UseVisualStyleBackColor = true;
            this.btn_ChangeFolder.Click += new System.EventHandler(this.btn_ChangeFolder_Click);
            // 
            // tb_Directory
            // 
            this.tb_Directory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Directory.Location = new System.Drawing.Point(11, 28);
            this.tb_Directory.Name = "tb_Directory";
            this.tb_Directory.Size = new System.Drawing.Size(430, 20);
            this.tb_Directory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change directory...";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(11, 227);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lb_SettingsSaved
            // 
            this.lb_SettingsSaved.AutoSize = true;
            this.lb_SettingsSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SettingsSaved.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_SettingsSaved.Location = new System.Drawing.Point(92, 229);
            this.lb_SettingsSaved.Name = "lb_SettingsSaved";
            this.lb_SettingsSaved.Size = new System.Drawing.Size(0, 17);
            this.lb_SettingsSaved.TabIndex = 4;
            // 
            // F2_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.lb_SettingsSaved);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Directory);
            this.Controls.Add(this.btn_ChangeFolder);
            this.MinimumSize = new System.Drawing.Size(300, 106);
            this.Name = "F2_Settings";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F2_Settings_Closed);
            this.Load += new System.EventHandler(this.F2_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ChangeFolder;
        private System.Windows.Forms.TextBox tb_Directory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lb_SettingsSaved;
    }
}