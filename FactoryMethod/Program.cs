using FactoryMethod.Class;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager(new LoggerFactory());
        customerManager.Save();
    }
}