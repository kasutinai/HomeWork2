using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{//Класс сериалов, наследован от все видео
    class SoapOpera : Video, IMyCloneable<SoapOpera>, ICloneable
    {
        public string SoapOperaName { get; set; }

        public SoapOpera(string videoName, string soapOperaName) : base (videoName)
        {
            SoapOperaName = soapOperaName;
        }

        public override SoapOpera MyClone()
        {
            return new SoapOpera(VideoName, SoapOperaName);
        }

        public override string ToString()
        {
            return SoapOperaName;
        }

        public object Clone()
        {
            return MyClone();
        }
    }
}
