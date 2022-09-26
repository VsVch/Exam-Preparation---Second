using System;

namespace _02._Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            double priceHavliq = double.Parse(Console.ReadLine());
            double persentDiscount = double.Parse(Console.ReadLine());

            double priceAmbrela = 2  * priceHavliq/3;
           
            double priceShoes = 3 * priceAmbrela / 4;

            double priceBag = 1  * (priceHavliq + priceShoes)/3;
            double sum = priceHavliq + priceAmbrela + priceShoes + priceBag;
            double afterDiscount = sum - sum * persentDiscount / 100;
            if (budjet >= afterDiscount)
            {
                Console.WriteLine($"Annie's sum is {afterDiscount:f2} lv. She has {(budjet - afterDiscount):f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {afterDiscount:f2} lv. She needs {(afterDiscount - budjet):f2} lv. more.");
            }


            //Console.WriteLine($"{(afterDiscount - budjet):f2}");
            



        }
    }
}
