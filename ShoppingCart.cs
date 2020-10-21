using System;
using System.Collections.Generic;
using System.Text;

namespace oop_week6_shoppingcart
{
    public class ShoppingCart 
    {
        List<double> Price;
        List<string> Courses;

        public double applePricee = 0.6;
        public double OrangePrice = 0.4;

        public void AddApple()
        {
            Courses.Add("apple");
        }

        public void AddOrange()
        {
            Courses.Add("orange");
        }

        public double PriceShoppingCart()
        {
            double total=0;

            foreach (string element in Courses)
            {
                if (element == "apple")
                {
                    total += 0.6;
                }
                else { total += 0.4; }
            }

            return total;
        }

    }
}
