using System.Collections.Generic;

namespace Plugin.Models.Show
{
    public class VirtualSeason
    {
        public int SeasonNumber { get; set; }
        public IEnumerable<VirtualEpisode> Episodes { get; set; }
    }
}
