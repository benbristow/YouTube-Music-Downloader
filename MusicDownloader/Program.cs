using System;
using System.Windows.Forms;
using System.IO;
using MusicDownloader.Lib;

namespace MusicDownloader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //If no download folder set, set.
            if(Properties.Settings.Default.downloadFolder == "")
            {
                Properties.Settings.Default.downloadFolder = Environment.CurrentDirectory + "\\Downloads";               
            }

            //If youtube-dl isn't downloaded, download
            if (!File.Exists("youtube-dl.exe"))
            {
                MessageBox.Show("YouTube DL isn't installed. We're going to install it for you. This may take a short while");
                Client.downloadYouTubeDL();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Main());
        }
    }
}
