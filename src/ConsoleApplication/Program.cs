using System;
using Logistics.Domain;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            AppContext context = new AppContext();

            foreach (var order in context.Orders)
            {
                Console.WriteLine($"Zamówienie {order.Id}:\n" +
                                  $"{order.Status}\n" +
                                  $"{order.Payment}\n" +
                                  $"{order.Value}");

            }

            context.SaveChanges();
            context.Dispose();
            
            Console.WriteLine("Koniec");
            Console.ReadKey();
        }
    }
}
