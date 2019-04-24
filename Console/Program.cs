using DrTvDownloader.Library;

namespace DrTvDownloader.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var downloader = new Downloader();
            downloader.FindNewEpisodes();
        }
    }
}