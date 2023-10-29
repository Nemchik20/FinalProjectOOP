namespace FinalProjectOOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] str = new string[] { "Молоко", "Хлеб", "Соль" };
            Product product = new Product(str);
            OrderUser orderUser = new OrderUser();
            List<int> ints = new();
            Print("Выбирайте продукт".EPoint() + "\nИспользуйте цифры");
            for (int i = 0; i < Product.strings.Count; i++)
            {
                Print($"{i + 1}-> {Product.strings[i]}".EPoint());
            }
            while (true)
            {
                int input = retInt(Console.ReadLine(), Product.strings.Count);

                if (input != 0)
                {
                    ints.Add(input -1);
                }
                else
                {
                    orderUser.UserOrder = ints.ToArray();
                    break;
                }
            }
            Print("Как вы хотите получить товар?\n1 -> Домой \n2 -> в пункт выдачи \n3 -> в магазин");
            int input2 = retInt(Console.ReadLine(), 3);
            switch(input2)
            {
                case 1:
                    Order<HomeDelivery> order = new( new HomeDelivery("Домой"), orderUser);
                    order.DisplayAddress();
                    break;
                case 2:
                    Order<PickPointDelivery> order1 = new(new PickPointDelivery("пункт выдачи"), orderUser);
                    order1.DisplayAddress();
                    break;
                case 3:
                    Order<ShopDelivery> order2 = new(new ShopDelivery("магазин"), orderUser);
                    order2.DisplayAddress();
                    break;
            }
            Console.ReadKey();
        }

        private static int retInt(string str, int b)
        {
            if (int.TryParse(str, out int result) && result <= b)
            {
                if (result == 0)
                {
                    return 0;
                }
                else
                {
                    return result;
                }
            }
            else
            {
                Print("Вы ввели не число".EPoint());
                return 0;
            }

        }
        private static void Print(string mess)
        {
            Console.WriteLine(mess);
        }
    }
}
