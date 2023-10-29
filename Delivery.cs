using System.Runtime.InteropServices;

namespace FinalProjectOOP
{
    abstract class Delivery
    {
        public string Address;
        public Delivery(string address)
        {
            Address = address;
        }
    }

    class HomeDelivery : Delivery
    {
        public HomeDelivery(string address) : base(address)
        {
        }
    }

    class PickPointDelivery : Delivery
    {
        public PickPointDelivery(string address) : base(address)
        {
        }
    }

    class ShopDelivery : Delivery
    {
        public ShopDelivery(string address) : base(address)
        {
        }
    }

    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;
        public OrderUser OUser;
        public Order(TDelivery delivery,  OrderUser orderUser)
        {
            Delivery = delivery;
            OUser = orderUser;
        }

        public void DisplayAddress()
        {
            Console.WriteLine("Ваш заказ ->");
            foreach(int n in OUser.UserOrder)
            {
                Console.WriteLine(Product.strings[n]);
            } 
            Console.WriteLine($"Будет доставлено в {Delivery.Address}");
        }
    }
}
