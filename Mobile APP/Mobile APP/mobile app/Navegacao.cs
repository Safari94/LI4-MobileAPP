﻿using System;
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
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Mobile_APP
{
    public partial class Navegacao : Form
    {
       Cordenadas coords;


        public Navegacao()
        {
            InitializeComponent();
            coords = new Cordenadas();


        }

        public Navegacao(Cordenadas c)
        {
            InitializeComponent();
            coords = c;
            
        }
        private void mapa_Click(object sender, EventArgs e)
        {
            int i;
            GMapOverlay m = new GMapOverlay("markers");

            

           GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(coords.latitude, coords.longitude), GMarkerGoogleType.red);
           m.Markers.Add(marker);

           
            gMapControl1.Overlays.Add(m);

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap=true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(41.561694, -8.397218); // Possição atual DI
            gMapControl1.MinZoom =0;
            gMapControl1.MaxZoom =24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;


        }

        
    }
}
