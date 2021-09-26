using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{//Класс серии сериала
    class Episode : SoapOpera, IMyCloneable<Episode>, ICloneable
    {
        public int EpisodeNumber { get; set; }

        public Episode(string videoName, string soapOperaName, int episodeNumber) : base(videoName, soapOperaName)
        {
            EpisodeNumber = episodeNumber;
        }

        public override Episode MyClone()
        {
            return new Episode(VideoName, SoapOperaName, EpisodeNumber); 
        }

        public override string ToString()
        {
            return EpisodeNumber.ToString();
        }

        public object Clone()
        {
            return MyClone();
        }
    }
}
