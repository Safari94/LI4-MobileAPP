using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Mobile_APP
{
    class Missao
    {
        private Document doc;
        private List<PontoInteresee> pts;
        private List<Tarefa> tfs;
        private String estado;

        public Missao(List<PontoInteresee> p, List<Tarefa> tf, String es) {
            doc = new Document(iTextSharp.text.PageSize.LETTER,10,10,42,35);
            pts = p.ToList();
            tfs = tf.ToList();
            estado = es;
        }

        public Document Documento { get; set; }
        public String Estado { get; set; }
        public List<PontoInteresee> Pts { get; set; }
        public List<Tarefa> Tfs { get; set; }
    }
}
