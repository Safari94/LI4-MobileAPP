using Mobile_APP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Mobile_APP
{
    class PontoInteresee
    {
        private Cordenadas coord;
        private XmlDocument voz;
        private String nota;
        private Image imagem;

        public PontoInteresee(Cordenadas cord, String n, Image i) {
            coord = cord;
            voz = new XmlDocument();
            nota = n;
            imagem =i;
        }

        public Cordenadas Coord { get; set; }
        public String Nota { get; set; }
        public Image Imagem { get; set; }
        public XmlDocument Voz { get; set; }

    }
}
