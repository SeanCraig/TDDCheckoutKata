using System;

namespace TDDCheckoutKata
{
    public class ShoppingCart
    {
        public static int Checkout(string basket)
        {
            var total = 0;
            char[] items = basket.ToCharArray();

            foreach (var item in items)
            {
                if (item.Equals(Convert.ToChar("A")))
            {
                total+= 50;
            }
                else if (item.Equals(Convert.ToChar("B")))
            {
                total += 30;
            }
                else if (item.Equals(Convert.ToChar("C")))
            {
                total += 20;
            }
                else if (item.Equals(Convert.ToChar("D")))
            {
                total += 15;
            }
            }
    return total ;


    }
    }
}
