using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);
    static bool showMessage = false;

    static async Task Main()
    {
        Task printTask = Printnumbers();
        Task messageTask = Periodicmessage();

        await Task.WhenAll(printTask, messageTask);
    }

    static async Task Printnumbers()
    {
        while (true)
        {
            await semaphore.WaitAsync();
            if (!showMessage)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("10");
            }
            semaphore.Release();
            await Task.Delay(100);
        }
    }

    static async Task Periodicmessage()
    {
        while (true)
        {
            await Task.Delay(5000);
            await semaphore.WaitAsync();
            showMessage = true;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nNeo, you are the chosen one");
            await Task.Delay(5000);
            showMessage = false;
            semaphore.Release();
        }
    }
}