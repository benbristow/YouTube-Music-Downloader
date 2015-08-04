using System;

using WrapYoutubeDl;
using System.IO;

namespace MusicDownloader.Lib
{
    public class Video 
    {      
        public string id { get;  set; }
        public string title { get { return getTitle(); } set { _title = value; }}
        public DateTime date { get; set; }
        private string _title;
        
        private string getTitle()
        {
            var newTitle = _title;

            //Remove unallowed characters for windows files
            foreach(char c in Path.GetInvalidFileNameChars())
            {
                newTitle = newTitle.Replace(c.ToString(), "");
            }

            return newTitle;
        }

        public Boolean isValid()
        {
            //Not valid if no ID
            if (id == null)
            {
                return false;
            }

            //Not valid if official music video, but valid if official lyric video
            //Official videos often have added sound effects etc.
            if (title.ToLower().Contains("official") && !title.ToLower().Contains("lyric"))
            {
                return false;
            }

            //Not valid if live, parody, cover or karaoke
            //@ assumes it's live.
            if(title.ToLower().Contains("live") || title.ToLower().Contains("parody") || title.Contains("@") ||  title.ToLower().Contains("cover") || title.ToLower().Contains("karaoke"))
            {
                return false;
            }

            //Not valid if contains full album
            if (title.ToLower().Contains("full album"))
            {
                return false;
            }

            //Not valid if doesn't contain -
            if (!title.ToLower().Contains(" - "))
            {
                return false;
            }

            return true;
        }

        public async void download()
        {
            //Create DL folder if doesn't exist
            if (!Directory.Exists(Properties.Settings.Default.downloadFolder)) {
                Directory.CreateDirectory(Properties.Settings.Default.downloadFolder);
            }

            //Download MP3            
            try
            {
                AudioDownloader downloader = new AudioDownloader(getWatchLink(), title, Properties.Settings.Default.downloadFolder, true);
                downloader.Download();
            }
            catch { }
        }

        public string getWatchLink()
        {
            return string.Format("https://www.youtube.com/watch?v={0}", id);
        }
    }
}
