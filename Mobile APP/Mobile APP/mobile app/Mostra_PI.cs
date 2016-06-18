using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_APP
{
    
    public partial class Mostra_PI : Form
    {
        Navegacao nv;
        List<PontoInteresee> pi;

        public Mostra_PI()
        {
            InitializeComponent();
            pi = new List<PontoInteresee>();
        }

       



        //Mostrar Mapa (vamos passar como argumento as coordenadas do ponto de interesse selecionado)
        private void nav_Click(object sender, EventArgs e)
        {
            nv = new Navegacao();
            nv.Show();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            interesse.DataSource = pi;
        }
    }
}
