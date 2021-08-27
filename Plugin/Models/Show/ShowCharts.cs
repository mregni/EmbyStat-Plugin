using System.Collections.Generic;
using Plugin.Models.Charts;

namespace Plugin.Models.Show
{
    public class ShowCharts
    {
        public List<Chart> BarCharts { get; set; }
        public List<Chart> PieCharts { get; set; }

        public ShowCharts()
        {
            BarCharts = new List<Chart>();
            PieCharts = new List<Chart>();
        }
    }
}
