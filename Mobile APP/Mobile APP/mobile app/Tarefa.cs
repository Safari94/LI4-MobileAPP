using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_APP
{
    class Tarefa
    {
        private String descricao;
        private bool estado; // vai indicar se ja esta feita  ou nao
        private Cordenadas coord; // Coordenada de cada Tarefa

        public Tarefa(string x, bool est, Cordenadas c) {
            this.descricao = x;
            this.estado = est;
            this.coord = c;
        }

        public String ToString()
        {
            return "Descricao= "+descricao + ";" + "Estado= " + estado + ";" + "Latitude= " + coord.Latitude + ";" + "Longitude= " + coord.Longitude;
                  
        }

        public String Descricao { get; set;}
        public bool Estado { get; set; }
        public Cordenadas Coord {get; set;}
    }
}
