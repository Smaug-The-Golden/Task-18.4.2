using System;
using System.Threading.Tasks;

namespace Task_18._4._2
{
    class Downloader
    {
        Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public async Task Run(string youtube_link)
        {
            await command.Run(youtube_link);
        }
    }
}
