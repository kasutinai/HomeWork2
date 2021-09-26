using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{//Класс видео, к которому относятся все видео (уроки, фильмы, мультфильмы и т.д.)
    class Video : IMyCloneable<Video>, ICloneable
    {
        public string VideoName { get; set; }

        public Video(string videoName)
        {
            VideoName = videoName;
        }

        public virtual Video MyClone()
        {
            return new Video(VideoName);
        }

        public override string ToString()
        {
            return VideoName;
        }

        public object Clone()
        {
            return MyClone();
        }
    }
}
