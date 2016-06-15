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
    public partial class Navegacao : Form
    {
        //public List<Cordenadas> coords;
        

        public Navegacao()
        {
            InitializeComponent();
            

        }

        

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try {

                StringBuilder query = new StringBuilder();
                query.Append("http://maps.googleapis.com/maps/api/geocode/xml?latlng={0},{1}&sensor=false");

                map.Navigate(query.ToString());
            }

            catch(Exception ex) {

                MessageBox.Show(ex.Message.ToString(), "ERROR");
            }
            
        }
    }
}
