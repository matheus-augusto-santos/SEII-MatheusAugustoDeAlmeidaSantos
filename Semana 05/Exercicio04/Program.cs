using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using System.Collections.Generic;

namespace AsyncAwaitDemo
{
    class Program
    {
        static async Task Main(string[]args)
        {
            string URL ="https://raw.githubusercontent.com/l3oxer/Doggo/main/README.md";
            Stopwatch sw = new Stopwatch();

            sw.Start();

            var tasks = new List<Task>{ SummonDogLocally(), SummonDogFromURL(URL)};
            await Task.WhenAll(tasks);

            sw.Stop();

            Console.WriteLine("We are done here ...."+ sw.Elapsed.TotalSeconds);

        }

        static async Task SummonDogLocally()
        {
            Console.WriteLine("1. Summoning Dog Locally ...");

            string dogText = await File.ReadAllTextAsync("dog.txt");

            Console.WriteLine($"2. Dog Summoned Locally  \n{dogText}");

        }

        static async Task SummonDogFromURL(string URL)
        {
            Console.WriteLine("1.Summoning Dog from URL ...");

            using(var httpClient = new HttpClient())
            {
               string result = await httpClient.GetStringAsync(URL);
               Console.WriteLine($"2.Dog Summoned from URL \n{result}");
            }
        }
    }
}