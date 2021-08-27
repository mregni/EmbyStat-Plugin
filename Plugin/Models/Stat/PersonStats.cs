﻿using System.Collections.Generic;
using Plugin.Models.Cards;

namespace Plugin.Models.Stat
{
    public class PersonStats
    {
        public List<Card<string>> Cards { get; set; }
        public List<TopCard> GlobalCards { get; set; }
        public List<TopCard> MostFeaturedActorsPerGenreCards { get; set; }
    }
}
