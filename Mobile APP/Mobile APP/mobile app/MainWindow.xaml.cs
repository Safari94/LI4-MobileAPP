using System;
using System.Collections.Generic;
using System.Windows;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Net.Sockets;
using System.IO.Ports;
using System.Threading;

namespace Mobile_APP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String nomeFicheiro;
        String Missão;
        Notepad nt;
        Mosta_tarefas mt;
        Mostra_PI mpi;
        List<PontoInteresee> pts;
        List<Tarefa> tf;
        Foto ft;
        
         static SerialPort porta;
        String data;

        public MainWindow()
        {
            InitializeComponent();
            
            tf = new List<Tarefa>();
           
           
            nomeFicheiro = "";
            SerialPort porta = new SerialPort("COM7", 9600, Parity.None, 8, StopBits.One);
            data = "";



        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mpi = new Mostra_PI();
            mpi.Show();
            
        }


        // Gera relatorio
        private void pdf_Click(object sender, RoutedEventArgs e)
        {
            //this.insereTarefas();
            int r = 1;

            Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35); // vai ser inicializado na class Missão
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(nomeFicheiro+".pdf", FileMode.Create));

            doc.Open();
            iTextSharp.text.Paragraph p = new iTextSharp.text.Paragraph("Relatorio Oficial da Missao" + "\n\n" + "Tarefas:\n");
            doc.Add(p);


            foreach (Tarefa i in tf)
            {

                p = new iTextSharp.text.Paragraph(r + ") --> " + i.ToString());
                doc.Add(p);
                r++;

            }
            p = new iTextSharp.text.Paragraph("Notas: \n \n");
            doc.Add(p);
            List<String> nts = nt.getNotas();

            foreach (String n in nts) {
                p = new iTextSharp.text.Paragraph(n);
                doc.Add(p);
            }
            



            doc.Close();

        }




        private void verTarefas_Click(object sender, RoutedEventArgs e)
        {
            mt = new Mosta_tarefas();
            mt.Show();
        }

        // NotePad
        private void button_Click_1(object sender, RoutedEventArgs e)
        {

            nt = new Notepad();
            nt.Show();
            

        }

        
      
        private void saveNome_Click(object sender, RoutedEventArgs e)
        {
            nomeFicheiro = nomefich.Text;
        }
    
        //Enviar dados para BO
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           /*Vai enviar o relatorio, fotos, notas e imagens captadas*/

        }

        //Receber dados da BO
        private void rececpaoDados_Click(object sender, RoutedEventArgs e)
        {

            porta.Open();
            
            data = porta.ReadLine(); // vai receber o tamanho da lista de tarefas
            int tTarefas = Int32.Parse(data); 
            // vai receber tarefa a tarefa e inserir na list correspondente
            for (int i = 0; i < tTarefas; i++) {
                data = porta.ReadLine();
                string[] words = data.Split(',');
                
                Tarefa tarefa = new Tarefa(words[0], false, float.Parse(words[1]), float.Parse(words[2]));
                tf.Add(tarefa);
              }

            data = porta.ReadLine();
            int tPi = Int32.Parse(data);

            for (int i = 0; i < tPi; i++) {

                data = porta.ReadLine();
                string[] words = data.Split(',');
                
                PontoInteresee PI = new PontoInteresee(float.Parse(words[0]), float.Parse(words[1]), words[2], words[3]);
                pts.Add(PI);



            }
            MessageBox.Show("Transferencia Completa");

            porta.Close();







        }

        private void iphoto1_Click(object sender, RoutedEventArgs e)
        {
            ft = new Foto();
            ft.Show();

        }

        private void gravarVoz_Click(object sender, RoutedEventArgs e)
        {
            GravarVoz gravar = new GravarVoz();
            gravar.Show();
        }
    }
}
