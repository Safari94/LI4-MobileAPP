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

        public Tarefa(string x) {
            this.descricao = x;
        }

        public String Descricao { get; set; }
    }
}
