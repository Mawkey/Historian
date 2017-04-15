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
using System.Collections.Specialized;

namespace Historian
{
    public partial class F1_MainForm : Form
    {
        FolderBrowserDialog browseDir;
        F2_Settings fSettings;


        FolderDir folderDir;

        Session session;

        StringCollection historyStringColl;

        public F1_MainForm()
        {
            folderDir = new FolderDir();
            session = new Session();

            browseDir = new FolderBrowserDialog();
            fSettings = new F2_Settings(folderDir);

            historyStringColl = new StringCollection();

            InitializeComponent();

            //Loads the string setting "dirPath" into folderDir.Path.
            folderDir.Path = Engine_Settings.LoadString("dirPath");

            //If the property contains something, proceed. Otherwise, skip.
            if (Engine_Settings.IsStringListEmpty() == false)
            {
                var list = Engine_Settings.LoadStringList();
                lb_History.Items.AddRange(list.ToArray()); //Add the contents of "stringList" to lb_history.
            }
            else
            {
                lb_History.Items.Add("No .mkv files found.");
            }
        }

        public void Refresh_lb_History()
        {
            lb_History.Items.Clear();
            lb_History.Items.AddRange(folderDir.GetAllFiles()); //Gets all files from the current dir.
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void directoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Browser dialog.
            browseDir.ShowDialog(this);

            //The folder path gets set here.
            folderDir.Path = browseDir.SelectedPath;

            lb_History.Items.AddRange(folderDir.GetAllFiles());
        }

        private void F1_MainForm_Load(object sender, EventArgs e)
        {

        }

        private void OnApp_Exit(object sender, FormClosingEventArgs e)
        {

        }

        private void Settings_Clicked(object sender, EventArgs e)
        {
            fSettings.SetTb_Directory(folderDir.Path);
            fSettings.ShowDialog(this);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_SaveList_Click(object sender, EventArgs e)
        {
            var list = lb_History.Items.Cast<string>().ToList();
            historyStringColl.AddRange(list.ToArray());
           Engine.Engine_Settings.SaveStringList(historyStringColl); //Adds the contents of lb_History to stringList.
            Engine_Settings.SaveSettings();
        }
    }
}
