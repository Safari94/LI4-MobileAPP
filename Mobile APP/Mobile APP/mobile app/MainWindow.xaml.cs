using Mobile_APP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;

namespace Mobile_APP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Navegacao nv;
        List<Cordenadas> coord;
        Missao missao;
        List<PontoInteresee> pts;
        List<Tarefa> tf;
     
            public MainWindow()
        {
            InitializeComponent();
            coord = new List<Cordenadas>();
            tf = new List<Tarefa>();
            insereCoordenadas();
            

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            nv = new Navegacao(coord);
            nv.Show();
        }

        private void pdf_Click(object sender, RoutedEventArgs e)
        {
            this.insereTarefas();
            int r = 1;

            Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35); // vai ser inicializado na class Missão
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Relatorio_Missao.pdf", FileMode.Create));

            doc.Open();
            iTextSharp.text.Paragraph p = new iTextSharp.text.Paragraph("Relatorio Oficial da Missao"+"\n\n" + "Tarefas:\n");
            doc.Add(p);
           
            
            foreach (Tarefa i in tf) {

            p = new iTextSharp.text.Paragraph(r + ") --> " + i.ToString());
            doc.Add(p);
            r++;

            }


            doc.Close();

        }

        public void insereCoordenadas() {

            Cordenadas x = new Cordenadas(41.585773, -8.359406);
            coord.Add(x);
            Cordenadas y = new Cordenadas(41.600865, -8.343582);
            coord.Add(y);
            Cordenadas z = new Cordenadas(41.612735, -8.352620);
            coord.Add(z);
            Cordenadas d = new Cordenadas(41.591438, -8.372014);
            coord.Add(d);
            

        }

        public void insereTarefas() {
            Cordenadas x = new Cordenadas(41.585773, -8.359406);
            Tarefa tf1 = new Tarefa("Matar um general Islamico",false,x);
            tf.Add(tf1);
            Tarefa tf2 = new Tarefa("Resgatar refens ", false, x);
            tf.Add(tf2);
            Tarefa tf3 = new Tarefa("Proteger civilização", false, x);
            tf.Add(tf3);
            Tarefa tf4 = new Tarefa("Escoltar comida para pobres", false, x);
            tf.Add(tf4);
            Tarefa tf5 = new Tarefa("Matar um general Islamico", false, x);
            tf.Add(tf5);

            
        }

       

        

        private void tarefas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("NAME", typeof(string));
            table.Columns.Add("CITY", typeof(string));
            table.Rows.Add(111, "Devesh", "Ghaziabad");
            table.Rows.Add(222, "ROLI", "KANPUR");
            table.Rows.Add(102, "ROLI", "MAINPURI");
            table.Rows.Add(212, "DEVESH", "KANPUR");
            tarefas.ItemsSource = table;



        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
