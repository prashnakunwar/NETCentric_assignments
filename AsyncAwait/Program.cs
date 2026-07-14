using System;
using System.Threading.Tasks;

class AsyncProgram
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Start");
        await SayHelloAsync();
        Console.WriteLine("End");
    }

    static async Task SayHelloAsync()
    {
        await Task.Delay(2000);
        Console.WriteLine("Hello after 2 seconds!");
    }
}