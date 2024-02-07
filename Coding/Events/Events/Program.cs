using System;
namespace Events
{
    class Program
    {
        public static void Main()
        {
            Application a1 = new Application();
            a1.ProcessCompleted += a1_ProcessCompleted;//register with an event
            a1.startProcess();
        }
        //event handler
        public static void a1_ProcessCompleted()
        {
            Console.WriteLine("process completed.");
            Console.ReadLine();
        }

    }
    // delegate
    public delegate void Notify();
    public class Application
    {
        public event Notify ProcessCompleted;//event
        public void startProcess()
        {
            Console.WriteLine("process started");
            OnProcessCompleted();
        }
        protected virtual void OnProcessCompleted()
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();
        }
    }
        
        
        



}
