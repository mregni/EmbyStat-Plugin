using System;
using MediaBrowser.Controller.Entities.TV;

namespace Plugin.Models.Show
{
    public class VirtualEpisode
    {
        public VirtualEpisode()
        {
            
        }

        public VirtualEpisode(Episode episode, Season season)
        {
            Id = episode.Id;
            Name = episode.Name;
            SeasonNumber = season?.IndexNumber ?? 0;
            EpisodeNumber = episode.IndexNumber ?? 0;
            FirstAired = episode.PremiereDate;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public DateTimeOffset? FirstAired { get; set; }
    }
}
