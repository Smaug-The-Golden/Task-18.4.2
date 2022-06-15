using System;
using System.Threading.Tasks;

namespace Task_18._4._2
{
    public abstract class Command
    {
        public abstract Task Run(string arg);
    }
}
