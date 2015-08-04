using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

using Newtonsoft.Json;
using System.ComponentModel;

namespace MusicDownloader.Lib
{
    public static class Client
    {
        //Get your own API key from YouTube
        private const string API_KEY = "";

        private const string API_ENDPOINT = "https://www.googleapis.com/youtube/v3";
        private const string YOUTUBE_DL_PATH = "http://yt-dl.org/latest/youtube-dl.exe";

        public static BindingList<Video> videos = new BindingList<Video>();

        public async static void search(string query)
        {        
            using(WebClient c = new WebClient())
            {                               
                c.Headers.Add("Content-Type", "application/json");
                var requestUri = new Uri(string.Format("{0}/search?part=snippet&q={1}&maxResults=50&key={2}&type=video&videoCategoryId=10", API_ENDPOINT, query, API_KEY));
                var json = await c.DownloadStringTaskAsync(requestUri);
                var jsonObject = JsonConvert.DeserializeObject<YouTubeResponse>(json);

                videos.Clear();                       

                foreach(var videoResult in jsonObject.items)
                {
                    var video = new Video();

                    video.title = Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(videoResult.snippet.title));
                    video.id = videoResult.id.videoId;
                    video.date = videoResult.snippet.publishedAt;

                    if (video.isValid())
                    {
                        videos.Add(video);
                    }
                }
            }
        }

        public static void downloadYouTubeDL()
        {
            using (WebClient c = new WebClient())
            {
                c.DownloadFile(YOUTUBE_DL_PATH, Environment.CurrentDirectory + "\\youtube-dl.exe");
            }        
        }
    }
}
