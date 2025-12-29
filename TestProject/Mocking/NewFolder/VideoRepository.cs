using TestNinja.Mocking;

namespace TestCasesProject.Mocking.NewFolder
{
   public interface IVideoRepository
    {
        IEnumerable<Video> GetVideos();
    }

    class VideoRepository : IVideoRepository
    {
        public IEnumerable<Video> GetVideos()
        {
            using (var context = new VideoContext())
            {
                return
                    (from video in context.Videos
                     where !video.IsProcessed
                     select video).ToList();


            }
        }
    }
}
