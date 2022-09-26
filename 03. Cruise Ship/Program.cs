using System;

namespace _03._Cruise_Ship
{
    class Program
    {
        static void Main(string[] args)
        {

            string typeCruiz = Console.ReadLine();
            string typeRoom = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            double priceForNight = 0;
            double priceForAllNigths = 0;

            switch (typeCruiz)
            {

                case "Mediterranean":
                    switch (typeRoom)
                    {
                        case "standard cabin":
                            priceForNight = 27.5;
                            break;
                        case "cabin with balcony":
                            priceForNight = 30.2;
                            break;
                        case "apartment":
                            priceForNight = 40.5;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Adriatic":
                    switch (typeRoom)
                    {
                        case "standard cabin":
                            priceForNight = 22.99;
                            break;
                        case "cabin with balcony":
                            priceForNight = 25.0;
                            break;
                        case "apartment":
                            priceForNight = 34.99;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Aegean":
                    switch (typeRoom)
                    {
                        case "standard cabin":
                            priceForNight = 23;
                            break;
                        case "cabin with balcony":
                            priceForNight = 26.6;
                            break;
                        case "apartment":
                            priceForNight = 39.8;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

           // Console.WriteLine($"{priceForNight}");

            if (nights > 7)
            {
                priceForAllNigths = (priceForNight - priceForNight*0.25) * nights*4;
            }
            else
            {
                priceForAllNigths = nights * priceForNight*4;
            }

            Console.WriteLine($"Annie's holiday in the {typeCruiz} sea costs {priceForAllNigths:f2} lv.");
        }
    }
}
