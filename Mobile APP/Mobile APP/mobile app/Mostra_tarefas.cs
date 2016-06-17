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
    public partial class Mosta_tarefas : Form
    {
        Cordenadas cd;
        Navegacao nv;
        public Mosta_tarefas()
        {
            InitializeComponent();
            cd = new Cordenadas();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            

            List<Tarefa> tf = new List<Tarefa>();

            Cordenadas x = new Cordenadas(41.585773, -8.359406);
            Tarefa tf1 = new Tarefa("Matar um general Islamico", false, x);
            tf.Add(tf1);
            Tarefa tf2 = new Tarefa("Resgatar refens ", false, x);
            tf.Add(tf2);
            Tarefa tf3 = new Tarefa("Proteger civilização", false, x);
            tf.Add(tf3);
            Tarefa tf4 = new Tarefa("Escoltar comida para pobres", false, x);
            tf.Add(tf4);
            Tarefa tf5 = new Tarefa("Matar um general Islamico", false, x);
            tf.Add(tf5);

            tfs.DataSource = tf;
        }

        private void verMapa_Click(object sender, EventArgs e)
        {
            nv = new Navegacao(cd);
            nv.Show();

        }

        private void tfs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = tfs.Rows[e.RowIndex].Cells[2].Value;
            cd = (Cordenadas) item;
            
        }
    }
    }

