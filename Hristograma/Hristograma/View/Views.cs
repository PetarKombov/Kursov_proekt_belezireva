using Hristograma.Module;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Hristograma.View
{
    public class Views
    {
        public int broi { get; set; }//prepertita

        public double P1 { get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }
        public double P4 { get; set; }
        public double P5 { get; set; }
        public  List<int> numbers { get; set; }
        public void DisplayInput()
        {
            Console.Write("Enter the number of elements: ");
            broi = int.Parse(Console.ReadLine());
            numbers = new List<int>();

            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < broi; i++)
            {
                int j = int.Parse(Console.ReadLine());
                numbers.Add(j);
            }
        }
        public void DisplayOutput()
        {
            Console.WriteLine($"Percent of numbers bellow 200: {P1}%");
            Console.WriteLine($"Percent of numbers from 200 to 399: {P2}%");
            Console.WriteLine($"Percent of numbers from 400 to 599: {P3}%");
            Console.WriteLine($"Percent of numbers from 600 to 799: {P4}%");
            Console.WriteLine($"Percent of numbers from 800 to 999: {P5}%");
        }    
    }
}
