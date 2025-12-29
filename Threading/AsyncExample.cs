using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace OPPS.Threading
{
    class AsyncExample
    {
        static async Task Main()
        {
            var urls = new List<string>
        {
            "https://example.com",
            "https://www.google.com",
            "https://www.bing.com"
        };

            foreach (var url in urls)
            {
                var result = await GetDataAsync(url);
                Console.WriteLine($"Data received from {url.Substring(0, 30)}... Length: {result.Length}");
            }
        }

        static async Task<string> GetDataAsync(string url)
        {
            Console.WriteLine($"[Async] Start {url} on Thread {Thread.CurrentThread.ManagedThreadId}");

            var httpClient = new HttpClient();
            var data = await httpClient.GetStringAsync(url);

            Console.WriteLine($"[Async] Done {url} on Thread {Thread.CurrentThread.ManagedThreadId}");
            return data;
        }
    }
}
