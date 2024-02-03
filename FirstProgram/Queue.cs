using System;
namespace Queue
{
    class Queue1
    {
        public static void Queue2()
        {

            // Queue<int> q = new Queue<int>();
            // while (q.Count > 0)
            // {
            //     q.Dequeue();

            // }
            // q.Enqueue(1);
            // q.Enqueue(2);
            // q.Enqueue(3);
            // q.Peek();

            Queue<Order> q = new Queue<Order>();

            foreach (Order o in ReceiveOrderFromBranch1())
            {
                q.Enqueue(o);

            }


            foreach (Order o in ReceiveOrderFromBranch2())
            {
                q.Enqueue(o);

            }

            while (q.Count > 0)
            {
                Order x = q.Dequeue();
                x.ProcessOrder();
            }

            static Order[] ReceiveOrderFromBranch1()
            {
                Order[] orders = new Order[]{
                new Order(1,5),
                new Order(2,4),
                new Order(6,10),
                };
                return orders;

            };

            static Order[] ReceiveOrderFromBranch2()
            {
                Order[] orders = new Order[]{
                new Order(3,5),
                new Order(4,4),
                new Order(5,10),
                };
                return orders;

            };

        }
    }
    class Order
    {
        public int OrderId { get; set; }

        public int OrderQuantity { get; set; }

        public Order(int OrderId, int OrderQuantity)
        {
            this.OrderId = OrderId;
            this.OrderQuantity = OrderQuantity;
        }
        public void ProcessOrder()
        {
            System.Console.WriteLine($"Order {OrderId} processed");
        }
    }
}