namespace AsyncDemo1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(Process1);
            task1.Start();
            Thread.Sleep(3000);
            Process2();
            Console.ReadKey();
        }
        static void Process1()
        {
            Console.WriteLine("1. isleme basladi");
            Console.WriteLine($"Thread No: {Thread.CurrentThread.ManagedThreadId}");
        }
        static void Process2()
        {
            Console.WriteLine("2. isleme basladi");
            Console.WriteLine($"Thread No: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
