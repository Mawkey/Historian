using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace Historian
{
    public partial class F2_Settings : Form
    {
        FolderBrowserDialog browseDir;
        FolderDir folderDir;
        F1_MainForm f1_MainForm;

        public F2_Settings(FolderDir folderDir)
        {
            this.folderDir = folderDir;
            browseDir = new FolderBrowserDialog();

            f1_MainForm.Parent = this;

            InitializeComponent();
        }

        private void btn_ChangeFolder_Click(object sender, EventArgs e)
        {
            browseDir.ShowDialog(this);

            //Assigns the path to the textbox.
            tb_Directory.Text = browseDir.SelectedPath;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //The folder path gets set here.
            folderDir.Path = tb_Directory.Text;

            Engine_Settings.SaveString("dirPath", folderDir.Path);
            Engine_Settings.SaveSettings();

            lb_SettingsSaved.Text = "Settings saved!";
        }

        private void F2_Settings_Load(object sender, EventArgs e)
        {
        }

        public void SetTb_Directory(string text)
        {
            tb_Directory.Text = text;
        }

        private void F2_Settings_Closed(object sender, FormClosedEventArgs e)
        {
            lb_SettingsSaved.Text = "";
        }
    }
}
