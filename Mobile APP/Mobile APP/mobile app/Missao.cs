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
        public Document doc { get; set; }
        public List<PontoInteresee> pts { get; set; }
        public List<Tarefa> tfs { get; set; }
        public String estado { get; set; }

        public Missao(List<PontoInteresee> p, List<Tarefa> tf, String es) {
            doc = new Document(iTextSharp.text.PageSize.LETTER,10,10,42,35);
            pts = p.ToList();
            tfs = tf.ToList();
            estado = es;
        }

        public List<Cordenadas> getCoordenadasTarefas() {

            List<Cordenadas> aux = new List<Cordenadas>();

            foreach (Tarefa tf in tfs) {

                aux.Add(tf.coord);
            }

            return aux;
        }

        public List<Cordenadas> getCoordenadasPtsInteresse()
        {

            List<Cordenadas> aux = new List<Cordenadas>();

            foreach (PontoInteresee pi in pts)
            {

                aux.Add(pi.coord);
            }

            return aux;
        }






    }
}
