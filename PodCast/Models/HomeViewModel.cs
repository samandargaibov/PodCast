using PodCast.DAL.Entities;

namespace PodCast.Models
{
    public class HomeViewModel
    {
        public List<Speaker> Speakers { get; set;}
        public List<Episode> Episodes { get; set;}
        public List<Topic> Topics { get; set;}
        public List<Episode> LatesEpisodes { get; set;}
        public List<Episode> TrendingEpisodes { get; set;}
    }
}
