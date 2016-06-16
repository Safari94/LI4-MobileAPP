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
        public Cordenadas coord { get; set; }
        public XmlDocument voz;
        public String nota;
        public Image imagem;

        public PontoInteresee(Cordenadas cord, String n, Image i) {
            coord = cord;
            voz = new XmlDocument();
            nota = n;
            imagem =i;
        }

        public String toString() {
            return coord.toString() + "; Nota: " + nota;
        }

        

       

    }
}
