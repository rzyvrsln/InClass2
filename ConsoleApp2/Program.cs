using ConsoleApp2.Models;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            manager.Salary = 400;
            Console.WriteLine(manager.Salary);
        }
    }
}