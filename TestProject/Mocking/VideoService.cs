using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TestCasesProject.Mocking.NewFolder;

namespace TestNinja.Mocking
{
    public class VideoService
    {
        private IFileReader FileReader { get; set; }
        public VideoService(IFileReader FileReader)
        {
            this.FileReader = FileReader;
        }
        public string ReadVideoTitle()
        {
            var str = FileReader.Read("video.txt"); //File.ReadAllText("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }

        public string GetUnprocessedVideosAsCsv(IVideoRepository repository)
        {
            var videoIds = new List<int>();

            var videos = repository.GetVideos();
            foreach (var v in videos)
                videoIds.Add(v.Id);

            return String.Join(",", videoIds);
        }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}