using System;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Task_18._4._2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var youtube_link = "https://www.youtube.com/watch?v=rx9r9Ttw4IY&ab_channel=DesolateFields";

            var downloader = new Downloader();
            var reciverClient = new YoutubeClient();

            var getinfo_command = new GetInfo_Command(reciverClient);
            downloader.SetCommand(getinfo_command);
            await downloader.Run(youtube_link);

            var download_command = new Download_Command(reciverClient);
            downloader.SetCommand(download_command);
            await downloader.Run(youtube_link);
        }
    }
}
