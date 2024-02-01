using System;
using System.Threading.Tasks;
class program
{
    static async Task Main()
    {
        Console.WriteLine("start");
        await performasync();
        Console.WriteLine("end");
    }
    static async Task performasync()
    {
        Console.WriteLine("inside performasync");
        await Task.Delay(1000);
        Console.WriteLine("async operation completed");
    }
}
