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
        String nomeF;
        Notepad nt;
        Mosta_tarefas mt;
        Mostra_PI mpi;
        List<PontoInteresee> pts;
        List<Tarefa> tf;
        List<String> notas;
        static bool _continue;
        static SerialPort porta;
        String data;

        public MainWindow()
        {
            InitializeComponent();
            
            tf = new List<Tarefa>();
           
            notas = new List<String>();
            nomeF = "";
            SerialPort porta = new SerialPort("COM6", 9600, Parity.None, 8, StopBits.One);
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
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(nomefich+".pdf", FileMode.Create));

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
            r = 0;
            foreach (String n in notas) {

                p = new iTextSharp.text.Paragraph(r + ") --> " + n);
                doc.Add(p);
                r++;
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
            string s = nt.getNota();
            notas.Add(s);

        }

        
      
        private void saveNome_Click(object sender, RoutedEventArgs e)
        {
            nomeF = nomefich.Text;
        }
    
        //Enviar dados para BO
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bool gest = true;
            
            porta.Open();
            while (gest)
            {
                data = " Insert into ";
                porta.Write(data);

                if (data.Equals("")) gest = false;
            }

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
                Cordenadas c = new Cordenadas(float.Parse(words[1]), float.Parse(words[2]));
                Tarefa tarefa = new Tarefa(words[0], false, c);
                tf.Add(tarefa);
              }

            data = porta.ReadLine();
            int tPi = Int32.Parse(data);

            for (int i = 0; i < tPi; i++) {

                data = porta.ReadLine();
                string[] words = data.Split(',');
                Cordenadas c = new Cordenadas(float.Parse(words[0]), float.Parse(words[1]));
                PontoInteresee PI = new PontoInteresee(c, words[2], words[3]);



            }
            MessageBox.Show("Transferencia Completa");

            porta.Close();







        }

      

       

        


    }
}
