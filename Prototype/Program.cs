using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video         = new Video("MyCloneVideo");
            SoapOpera soapOpera = new SoapOpera(video.VideoName, "MyCloneSoapOpera");
            Episode episode     = new Episode(soapOpera.VideoName, soapOpera.SoapOperaName, 2);

            Video video1            = video.MyClone();
            SoapOpera soapOpera1    = soapOpera.MyClone();
            Episode episode1        = episode.MyClone();

            ChangeAddress(video, "CloneVideo", soapOpera, "CloneSoapOpera", episode, 3);            

            Video video2            = (Video)video.Clone();
            SoapOpera soapOpera2    = (SoapOpera)soapOpera.Clone();
            Episode episode2        = (Episode)episode.Clone();

            ChangeAddress(video, "BasicVideo", soapOpera, "BasicSoapOpera", episode, 1);

            Console.WriteLine($"Basic : {video.ToString()} {soapOpera.ToString()} {episode.ToString()}");
            Console.WriteLine($"MyClone : {video1.ToString()} {soapOpera1.ToString()} {episode1.ToString()}");
            Console.WriteLine($"Clone : {video2.ToString()} {soapOpera2.ToString()} {episode2.ToString()}");

            Console.ReadKey();
        }

        public static void ChangeAddress(Video video, string videoName, SoapOpera soapOpera, string soapOperaName, Episode episode, int episodeNumber)
        {
            video.VideoName         = videoName;
            soapOpera.VideoName     = videoName;
            soapOpera.SoapOperaName = soapOperaName;
            episode.VideoName       = videoName;
            episode.SoapOperaName   = soapOperaName;
            episode.EpisodeNumber   = episodeNumber;
        }
    }
}
