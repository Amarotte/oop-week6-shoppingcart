using System;
using System.Collections.Generic;

namespace oop_week6_shoppingcart
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            //Classic example without Classes
            double totalshopping = 0;
            List<string> ShoppingToday = new List<string> { "apple", "orange","orange","apple","apple" }; // sum = 2.6
            foreach(string element in ShoppingToday)
            {
                if(element=="apple")
                {
                    totalshopping += 0.6;
                }
                else { totalshopping += 0.4; }
            }
            Console.WriteLine(totalshopping + " to pay please");         
        }
        
    }
}
