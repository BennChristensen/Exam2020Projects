using Example07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example07
{
    public static class MyExtensionMethods
    {
        public static string To1337(this string str)
        {
            StringBuilder leetString = new StringBuilder();
            foreach (char c in str.ToLower())
            {
                switch (c)
                {
                    case 'a':
                        leetString.Append('4');
                        break;
                    case 'b':
                        leetString.Append('8');
                        break;
                    case 'c':
                        leetString.Append('[');
                        break;
                    case 'd':
                        leetString.Append(')');
                        break;
                    case 'e':
                        leetString.Append('3');
                        break;
                    case 'f':
                        leetString.Append("|=");
                        break;
                    case 'g':
                        leetString.Append('6');
                        break;
                    case 'h':
                        leetString.Append('#');
                        break;
                    case 'l':
                        leetString.Append('1');
                        break;
                    case 'o':
                        leetString.Append('0');
                        break;
                    default:
                        leetString.Append(c);
                        break;
                }
            }
            List<string> a = new List<string>();
            return leetString.ToString();
        }

        public static string WhoSays(this ICanMakeSounds makeSounds)
        {
            return $"{makeSounds.GetType().Name} says {makeSounds.Says()}";
        }

    }
}
