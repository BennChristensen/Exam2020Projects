using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example07.Models
{
    public class Dog : Animal, ICanMakeSounds
    {
        public string Says()
        {
            return "wow, wow";
        }
    }
}
