using System;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Task_18._4._2
{
    class Download_Command : Command
    {
        YoutubeClient client;

        public Download_Command(YoutubeClient client)
        {
            this.client = client;
        }

        public override async Task Run(string arg)
        {
            Console.WriteLine();
            Console.WriteLine("Загрузка видео");

            await client.Videos.DownloadAsync(arg, $"{Guid.NewGuid()}.mp4",
                builder => builder.SetPreset(ConversionPreset.UltraFast));

            Console.WriteLine("Видео загружено");
            Console.WriteLine();
        }
    }
}
