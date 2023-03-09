using System;
using System.Collections.Generic;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Step 1:
                    Create at least one instance of each kind of candy
             */
            CandyBar Twix = new CandyBar();
            {
                Twix.Price = 1.75;
                Twix.Brand = "Mars";
                Twix.Name = "Twix";
                Twix.Weight = 1.5;
            }


            /*
                Step 2:
                    Create at least one instance of each kind of baked good
             */
            Cake RedVelvet = new Cake(false, true);
            {
                RedVelvet.Price = 3.50;
                RedVelvet.BakingTemperature = 350;
                RedVelvet.Name = "Red Velvet";
                RedVelvet.Weight = 2.5;
            }
            Cookie SnickerDoodle = new Cookie(false);
            {
                SnickerDoodle.BakingTemperature = 450;
                SnickerDoodle.Name = "SnickerDoodle";
                SnickerDoodle.Price = 1.50;
                SnickerDoodle.Weight = 1;
            }





            /*
                Step 3:
                    Create a List<> and add all baked goods to the list
             */
            List<BakedGood> bakedGoods = new List<BakedGood>()
            {
               RedVelvet,
               SnickerDoodle,
            };

            Console.WriteLine("____________Baked Goods_____________________");
            foreach (BakedGood good in bakedGoods)
            {
                Console.WriteLine(good.Name);
            }
        }
    }
}
