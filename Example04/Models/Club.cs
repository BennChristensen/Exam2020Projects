using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Example04.Models
{
    public class Club
    {
        public string Name { get; set; }
        public List<Match> Matches { get; } = new List<Match>();

        public int Wins
        {
            get
            {
                return (from match in Matches
                        where match.Result == MatchResult.Won
                        select 1).Count();
            }
        }

        public int Draws
        {
            get
            {
                return (from match in Matches
                        where match.Result == MatchResult.Draw
                        select 1).Count();
            }
        }

        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Club other = (Club)obj;
                return Name == other.Name;
            }
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
