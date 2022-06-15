using System;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Task_18._4._2
{
    class GetInfo_Command : Command
    {
        YoutubeClient client;

        public GetInfo_Command(YoutubeClient client)
        {
            this.client = client;
        }

        public override async Task Run(string arg)
        {
            Console.WriteLine();
            Console.WriteLine("Загрузка данных");

            var info = await client.Videos.GetAsync(arg);
            Console.WriteLine(info.Title);
            Console.WriteLine(info.Description);
            Console.WriteLine();
        }
    }
}
