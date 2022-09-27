using System;
using Enumerações.Entities.Enums;

namespace Enumerações
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.Write(order);

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}