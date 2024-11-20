using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Ex2
{
    internal class Program
    {
            static async Task Main(string[] args)
            {
                Console.WriteLine("Fetching data...");

                // Call an asynchronous method
                string result = await FetchDataAsync();

                Console.WriteLine(result);
                Console.WriteLine("Process complete.");
            }
           static async Task<string> FetchDataAsync()
          {
            // Simulate a delay (e.g., fetching data from a database or API)
            await Task.Delay(3000); // Simulate a 3-second delay

            return "Data fetched successfully!";
          }

    }
}
