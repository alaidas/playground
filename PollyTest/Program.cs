using System;
using Polly;
using System.Threading.Tasks;

namespace PollyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running...");

            RunAsync().Wait();

            Console.WriteLine("Stopped");
        }

        static async Task RunAsync()
        {
            try
            {
                await Policy.Handle<Exception>()
                .RetryAsync(2, (ex, retryCount) =>
                {
                    Console.WriteLine($"Count = {retryCount}");
                }).ExecuteAsync(() =>
                {
                    Console.WriteLine("Executing");
                    throw new Exception("This is moin");
                });
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception {ex.Message}");
            }
        }
    }
}
