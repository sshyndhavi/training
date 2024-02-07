using System;
namespace event_handlers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application a1 = new Application();
            a1.ProcessCompleted += a1_ProcessCompleted;
            a1.Startprocess();
        }
        public static void a1_ProcessCompleted(object sender ,EventArgs e)
        {
            Console.WriteLine("process completed");
            Console.ReadLine();
        }

    }
    public class Application
    {
        public event EventHandler ProcessCompleted;
        public void Startprocess()
        {
            Console.WriteLine("process started");
            OnProcessCompleted(EventArgs.Empty);//no event data
        }
        protected virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }
}

