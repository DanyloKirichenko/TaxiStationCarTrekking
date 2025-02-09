using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TaxiStationCarTrekking
{
    public partial class ViewDataForm : Form
    {
        public const string PATH_TRANSPORT = "transports.json";
        public static List<Transport> Transports;

        public ViewDataForm()
        {
            InitializeComponent();

            Transports = Transport.Import(PATH_TRANSPORT);

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 16;
            gMapControl1.Zoom = 4;
            gMapControl1.Position = new GMap.NET.PointLatLng(50.4547, 30.5238);
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.CanDragMap = true;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.ShowCenter = false;
            gMapControl1.ShowTileGridLines = false;

            UpdateListBox();
        }
        
        private void UpdateListBox()
        {
            if(ListOfTransport.Items.Count > 0)
            {
                ListOfTransport.Items.Clear();
            }
            foreach (var t in Transports)
            {
                ListOfTransport.Items.Add(t);
            }
            if (ListOfTransport.Items.Count > 0)
                ListOfTransport.SelectedIndex = 0;
        }
        private void ListOfTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListOfTransport.SelectedIndex >= 0)
            {
                var transport = ListOfTransport.SelectedItem as Transport;
                DetailsAboutTransport.Text = transport.ShowDetails();
                SetRouteOnMap(transport.Route, transport.CurrentPosition, transport.TypeOfTransport);
                gMapControl1.Zoom = 15;
            }
        }

        private void OpenAddForm_Click(object sender, EventArgs e)
        {
            AddDataForm f = new AddDataForm();
            f.FormClosed += F_FormClosed;
            f.ShowDialog();
        }
        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateListBox();
        }

        #region Menu

        private void CarSelected_Click(object sender, EventArgs e)
        {
            ClearMap();
            foreach (var t in Transports)
            {
                if (t.TypeOfTransport == TypeOfTransport.Car)
                {
                    SetPointOnMap(t.CurrentPosition, t.TypeOfTransport);
                }
            }
        }
        private void BusSelected_Click(object sender, EventArgs e)
        {
            ClearMap();
            foreach (var t in Transports)
            {
                if (t.TypeOfTransport == TypeOfTransport.Bus)
                {
                    SetPointOnMap(t.CurrentPosition, t.TypeOfTransport);
                }
            }
        }

        private void EconomySelected_Click(object sender, EventArgs e)
        {
            ClearMap();
            foreach (var t in Transports)
            {
                if(t.ClassOfTransport == ClassOfTransport.Economy)
                {
                    SetPointOnMap(t.CurrentPosition, t.TypeOfTransport);
                }
            }
        }
        private void StandartSelected_Click(object sender, EventArgs e)
        {
            ClearMap();
            foreach (var t in Transports)
            {
                if (t.ClassOfTransport == ClassOfTransport.Standard)
                {
                    SetPointOnMap(t.CurrentPosition, t.TypeOfTransport);
                }
            }
        }
        private void PremiumSelected_Click(object sender, EventArgs e)
        {
            ClearMap();
            foreach (var t in Transports)
            {
                if (t.ClassOfTransport == ClassOfTransport.Premium)
                {
                    SetPointOnMap(t.CurrentPosition, t.TypeOfTransport);
                }
            }
        }

        private void BusySelected_Click(object sender, EventArgs e)
        {
            ClearMap();
            foreach (var t in Transports)
            {
                if (!t.IsAvailable)
                {
                    SetPointOnMap(t.CurrentPosition, t.TypeOfTransport);
                }
            }
        }
        private void FreeSelected_Click(object sender, EventArgs e)
        {
            ClearMap();
            foreach (var t in Transports)
            {
                if (t.IsAvailable)
                {
                    SetPointOnMap(t.CurrentPosition, t.TypeOfTransport);
                }
            }
        }

        private void allTransportSelected_Click(object sender, EventArgs e)
        {
            ClearMap();
            foreach (var t in Transports)
            {
                SetPointOnMap(t.CurrentPosition, t.TypeOfTransport);
            }
        }
        #endregion
        
        private void SetPointOnMap(PointLatLng pointClick, TypeOfTransport type)
        {
            if (gMapControl1.Overlays.Count == 0)
            {
                gMapControl1.Overlays.Add(new GMapOverlay("MainOverlay"));
            }

            Bitmap bmp = null;
            if(type == TypeOfTransport.Car) bmp = Properties.Resources.car;
            else bmp = Properties.Resources.bus;

            GMapMarker marker = new GMarkerGoogle(pointClick, bmp);
            gMapControl1.Overlays[0].Markers.Add(marker);
        }
        private void SetRouteOnMap(Route route, PointLatLng currentPoint, TypeOfTransport type)
        {
            if (gMapControl1.Overlays.Count == 0)
            {
                gMapControl1.Overlays.Add(new GMapOverlay("MainOverlay"));
            }
            
            if (gMapControl1.Overlays[0].Routes.Count == 0)
            {
                gMapControl1.Overlays[0].Routes.Add(new GMapRoute("Новий маршрут"));
            }
            gMapControl1.Overlays[0].Routes[0].Points.Clear();
            if(route != null)
            {
                foreach (var point in route.RouteTransport)
                {
                    gMapControl1.Overlays[0].Routes[0].Points.Add(point);
                }
            }

            gMapControl1.Overlays[0].Markers.Clear();
            Bitmap bmp = null;
            if (type == TypeOfTransport.Car) bmp = Properties.Resources.car;
            else bmp = Properties.Resources.bus;
            GMapMarker marker = new GMarkerGoogle(currentPoint, bmp);
            gMapControl1.Overlays[0].Markers.Add(marker);
            gMapControl1.ZoomAndCenterMarkers("MainOverlay");
        }
        private void ClearMap()
        {
            if (gMapControl1.Overlays.Count > 0)
            {
                gMapControl1.Overlays[0].Markers.Clear();
                gMapControl1.Overlays[0].Routes.Clear();
            }
            gMapControl1.Overlays.Clear();
        }

        private void ViewDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Transport.Export(Transports, PATH_TRANSPORT);
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            DetailsAboutTransport.Text = "";
            var transports = Transports.FindAll(x => x.CurrentPosition == item.Position);
            foreach(var t in transports)
            {
                DetailsAboutTransport.Text += t.ShowDetails() + "\n\n";
            }
        }
    }
}
