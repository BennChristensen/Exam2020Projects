using Example01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 2;
            var p = new Person { Age = 17, Name = "Hans Hansen" };
            Increment(p, m);
            Console.WriteLine($"p.Age: {p.Age}, m: {m}");
            Console.ReadLine();
        }

        static void Increment(Person person, int n)
        {
            person.Age++;
            n++;
        }
    }
}
