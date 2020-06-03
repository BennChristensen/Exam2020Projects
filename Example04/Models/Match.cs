using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04.Models
{
    public class Match
    {
        public Club Against { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public MatchResult Result
        {
            get
            {
                if (GoalsFor > GoalsAgainst)
                {
                    return MatchResult.Won;
                }
                else if (GoalsFor == GoalsAgainst)
                {
                    return MatchResult.Draw;
                }
                else
                {
                    return MatchResult.Loss;
                }
            }
        }
    }
    public enum MatchResult
    {
        Won, Draw, Loss
    }

}
