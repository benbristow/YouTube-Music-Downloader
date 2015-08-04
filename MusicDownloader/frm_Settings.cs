using System;
using System.Windows.Forms;
using System.IO;

namespace MusicDownloader
{
    public partial class frm_Settings : Form
    {
        public frm_Settings()
        {
            InitializeComponent();
        }

        //Load settings into form
        private void frm_Settings_Load(object sender, EventArgs e)
        {
            txt_SaveDirectory.Text = Properties.Settings.Default.downloadFolder;
        }

        //Select Directory
        private void btn_SaveDirectoryBrowse_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();            
            fbd.SelectedPath = txt_SaveDirectory.Text;
            fbd.Description = "Select where you would like your music files to be stored";
            fbd.ShowDialog();
            txt_SaveDirectory.Text = fbd.SelectedPath;
        }

        //Save 
        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool valid = true;

            //Save directory
            if (Directory.Exists(txt_SaveDirectory.Text))
            {
                Properties.Settings.Default.downloadFolder = txt_SaveDirectory.Text;
            } else
            {
                MessageBox.Show("Invalid save directory");
                return;
            }

            //Save settings + close
            Properties.Settings.Default.Save();
            this.Close();
        }

        //Close button
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
