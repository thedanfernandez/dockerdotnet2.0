using System;
using System.Diagnostics;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //take input from args
            Process p = new Process();
            var start = new ProcessStartInfo("youtube-dl", "--write-info-json https://www.youtube.com/watch?v=Vhh_GeBPOhs");
            p.StartInfo = start;

            p.Start();
            p.WaitForExit();
        }
    }
}
