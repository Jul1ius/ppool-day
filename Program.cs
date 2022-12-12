using System;

namespace ppool_day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            double enterTaxs = double.Parse(Console.ReadLine());
            double shezlongCost = double.Parse(Console.ReadLine());
            double umbrellaCost = double.Parse(Console.ReadLine());


            double totalEntryCost = numPeople * enterTaxs;
            double totalShezlongCost = (Math.Ceiling(numPeople * 0.75)) * shezlongCost;
            double totalumbrellaCost = (Math.Ceiling(numPeople * 0.50)) * umbrellaCost;

            Console.WriteLine($"{totalumbrellaCost + totalShezlongCost + totalEntryCost:f2} lv.");
            
            //Console.WriteLine($"{(numPeople * entryCost) + (Math.Round(numPeople * 0.75) * shezlongCost) + (Math.Round(numPeople * 0.50) * umbrellaCost):f2} lv.");

        }
    }
}
