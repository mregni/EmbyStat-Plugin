﻿using Plugin.Models.Stat;

namespace Plugin.Models.Show
{
    public class ShowGeneral
    {
        public Card<int> ShowCount { get; set; }
        public Card<int> EpisodeCount { get; set; }
        public Card<int> MissingEpisodeCount { get; set; }
        public Card<double> TotalDiskSize { get; set; }
        public TimeSpanCard TotalPlayableTime { get; set; }
        public ShowPoster HighestRatedShow { get; set; }
        public ShowPoster LowestRatedShow { get; set; }
        public ShowPoster ShowWithMostEpisodes { get; set; }
        public ShowPoster OldestPremieredShow { get; set; }
        public ShowPoster NewestPremieredShow { get; set; }
        public ShowPoster LatestAddedShow{ get; set; }
    }
}
