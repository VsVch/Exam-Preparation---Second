using System;

namespace _01._Savings
{
    class Program
    {
        static void Main(string[] args)
        {

            double income = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double personSpends = double.Parse(Console.ReadLine());

            double spends = income * 30 / 100;
            double canSave = income - (spends + personSpends);
            double canSaves = months * canSave;
            double persentSave = canSave / income * 100;

            Console.WriteLine(  $"She can save {persentSave:f2}%");
            Console.WriteLine($"{canSaves:f2}");



        }
    }
}
