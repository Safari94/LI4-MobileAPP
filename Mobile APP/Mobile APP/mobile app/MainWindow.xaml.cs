﻿using Mobile_APP;
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
            public MainWindow()
        {
            InitializeComponent();
            coord = new List<Cordenadas>();
            insereCoordenadas();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            nv = new Navegacao(coord);
            nv.Show();
        }

        private void pdf_Click(object sender, RoutedEventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35); // vai ser inicializado na class Missão
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Relatorio_Missao.pdf", FileMode.Create));
            doc.Open();
            iTextSharp.text.Paragraph p = new iTextSharp.text.Paragraph("Relatorio Oficial da Missao");
            doc.Add(p);
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
    }
}
