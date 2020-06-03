using Example04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04.TestData
{
    public class TestDataGenerator
    {
        private List<Club> clubs;
        public TestDataGenerator()
        {
            clubs = new List<Club>();
            AddClubs();
            CreateMatches();
        }

        private void CreateMatches()
        {
            int homeGoals;
            int awayGoals;
            var random = new Random();
            foreach (var homeClub in clubs)
            {
                foreach (var awayClub in clubs)
                {
                    if (homeClub != awayClub)
                    {
                        homeGoals = random.Next(0, 6);
                        awayGoals = random.Next(0, 6);
                        homeClub.Matches.Add(new Match { Against = awayClub, GoalsFor = homeGoals, GoalsAgainst = awayGoals });
                        awayClub.Matches.Add(new Match { Against = homeClub, GoalsFor = awayGoals, GoalsAgainst = homeGoals }); 
                    }
                }
            }
        }

        private void AddClubs()
        {
            clubs.Add(new Club { Name = "FC Midtjylland" });
            clubs.Add(new Club { Name = "FC København" });
            clubs.Add(new Club { Name = "AGF" });
            clubs.Add(new Club { Name = "FC Nordsjælland" });
            clubs.Add(new Club { Name = "Brøndby IF" });
            clubs.Add(new Club { Name = "AaB" });
            clubs.Add(new Club { Name = "Randers FC" });
            clubs.Add(new Club { Name = "Lyngby" });
            clubs.Add(new Club { Name = "AC Horsens" });
            clubs.Add(new Club { Name = "OB" });
        }
        public List<Club> GetTestData()
        {
            return clubs;
        }
    }
}
