using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject
{
    public enum OrderState
    {
        Created,
        Accepted,
        Verified,
        Confirmed,
        Processing,
        Completed,
        Rejected
    }
    public class Order {
        private string Name;
        private OrderState State;

        public Order(string name)
        {
            Name = name;
            State = OrderState.Created;
        }
        public void ChangeState(OrderState state)
        {
            State = state;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Order order = new Order("SampleOrder");

            while (true)
            {
                int randomNumber = random.Next(10); 
                OrderState randomState = (OrderState)randomNumber;

                order.ChangeState(randomState);
                Console.WriteLine($"Order state changed to: {randomState}");

                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
