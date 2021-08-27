using System.Collections.Generic;
using Plugin.Models.Cards;
using Plugin.Models.Charts;
using Plugin.Models.Stat;

namespace Plugin.Models.Movie
{
    public class MovieStatistics
    {
        public List<Card<string>> Cards { get; set; }
        public List<TopCard> TopCards { get; set; }
        public List<Chart> Charts { get; set; }
        public PersonStats People { get; set; }
        public IEnumerable<ShortMovie> Shorts { get; set; }
        public IEnumerable<SuspiciousMovie> NoImdb { get; set; }
        public IEnumerable<SuspiciousMovie> NoPrimary { get; set; }
    }
}
