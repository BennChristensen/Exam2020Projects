using Example04.Models;
using Example04.TestData;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            var clubs = new TestDataGenerator().GetTestData();

            foreach (var club in clubs)
            {
                Console.WriteLine($"Klubnavn: {club.Name}. Antal sejre: {club.Wins}");
            }
            Console.ReadLine();
        }
    }
}
