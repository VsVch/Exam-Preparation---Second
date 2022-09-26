using System;

namespace _04._Darts_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {

            int point = int.Parse(Console.ReadLine());
            string section = Console.ReadLine();
            int br = 0;
            int newpoints = 0;

            while (point != 0 || point > 0 || section != "bullseye")
            {
                newpoints = int.Parse(Console.ReadLine());
                br++;
                switch (section)
                {
                    case "number section":
                        newpoints += newpoints;
                        point = -newpoints;
                        break;
                    case "double ring":
                        newpoints = newpoints + 2*newpoints;
                        point =  - newpoints;
                        break;
                    case "triple ring":
                        newpoints = newpoints + 3*newpoints;
                        point =  - newpoints;
                        break;

                    default:
                        break;
                }

                section = Console.ReadLine();
            }
            //section = Console.ReadLine();

            if (point == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {br} moves");
                
            }
            else if (section == "bullseye")
            {
                Console.WriteLine($"Congratulations! You won the game with a bullseye in {br} moves!");
                
                
            }
            else if (point < 0)
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {newpoints - point}.");
            }


        }
    }
}
