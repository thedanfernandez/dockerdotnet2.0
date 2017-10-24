using System;
using System.Diagnostics;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            string youtubeUrl = @"https://www.youtube.com/watch?v=Vhh_GeBPOhs";
            if (! string.IsNullOrEmpty(Environment.GetEnvironmentVariable("url")))
            {
                youtubeUrl = Environment.GetEnvironmentVariable("url");
            }

            //take input from args
            Process p = new Process();
            var start = new ProcessStartInfo("youtube-dl", "--write-info-json "+ youtubeUrl);
            p.StartInfo = start;

            p.Start();
            p.WaitForExit();
        }
    }
}
