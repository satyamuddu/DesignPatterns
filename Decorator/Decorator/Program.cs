namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ApplicationConfigurator applicationConfigurator = new ApplicationConfigurator();
            applicationConfigurator.ReadData();

            //another example below
            Application application = new Application();
            application.UsageExample();
        }
    }
}