using System.Collections.Generic;
using Plugin.Models.Cards;
using Plugin.Models.Charts;
using Plugin.Models.Stat;

namespace Plugin.Models.Show
{
    public class ShowStatistics
    {
        public List<Card<string>> Cards { get; set; }
        public List<TopCard> TopCards { get; set; }
        public List<Chart> BarCharts { get; set; }
        public List<Chart> PieCharts { get; set; }
        public PersonStats People { get; set; }
    }
}
