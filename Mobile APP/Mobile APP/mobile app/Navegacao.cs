using System;
using GMap.NET.MapProviders;
using GMap.NET;
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

        private void mapa_Click(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap=true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(37.983,-1.133);
            gMapControl1.MinZoom =0;
            gMapControl1.MaxZoom =24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;


        }
    }
}
