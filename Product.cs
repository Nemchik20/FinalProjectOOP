namespace FinalProjectOOP
{
    internal class Product
    {
        public static List<string> strings = new List<string>(); //статические массив продуктов
        public Product(string[] str) 
        {
            strings.AddRange(str);
        }
    }
    internal class OrderUser
    {
        private int[] userOrder = new int[] { };
        public int[] UserOrder
        {
            set { userOrder = value; }
            get { return userOrder; }
        }

    }
    internal static class EndPoint // просто ставит точку!
    {
        public static string EPoint(this string value)
        {
            return value +".";
        }
    }
}
