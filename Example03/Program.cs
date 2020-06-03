using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Program
    {
        private static List<string> greetings = new List<string> { "Hello", "Goodbye", "God morning", "Hey" };
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        public static void StringWriter(List<string> stringsToWrite, Func<string, string> formatter)
        {
            stringsToWrite.ForEach(s => Console.WriteLine(formatter(s)));
        }
    }
}
