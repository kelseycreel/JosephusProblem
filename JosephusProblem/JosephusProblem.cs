using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JosephusProblem
{
    public class JosephusProblem
    {
        public int LastPersonStanding(int numberOfPeople, int killingInterval)
        {
            
            List<int> totalPeople = Enumerable.Range(1, numberOfPeople).ToList();
            var killingTicker = 0;
            while (totalPeople.Count > 1)
            {
                foreach (var people in totalPeople.ToList())
                {
                    if (killingTicker % killingInterval == 0)
                    {
                        totalPeople.RemoveAt(people);
                    }
                    killingTicker++;
                }
            }
            var lastManStanding = totalPeople[0];
            return lastManStanding;
        }
    }
}
