using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TaxiStationCarTrekking
{
    public partial class AddDataForm : Form
    {
        public const string PATH_ROUTE = "route.json";
        private List<Route> route;
        Dictionary<string, TypeOfTransport> typeOfTransportList = new Dictionary<string, TypeOfTransport>()
        {
            { "Автобус", TypeOfTransport.Bus},
            { "Легковий автомобіль", TypeOfTransport.Car}
        };
        Dictionary<string, ClassOfTransport> classOfTransportList = new Dictionary<string, ClassOfTransport>()
        {
            { "Економ", ClassOfTransport.Economy},
            { "Преміум", ClassOfTransport.Premium},
            { "Стандарт", ClassOfTransport.Standard}
        };

        List<PointLatLng> pointOfNewRoute;

        public AddDataForm()
        {
            InitializeComponent();

            pointOfNewRoute = new List<PointLatLng>();
            route = Route.Import(PATH_ROUTE);

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; //выбор подгрузки карты – онлайн или из ресурсов
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; //какой провайдер карт используется (в нашем случае гугл) 
            gMapControl1.MinZoom = 2; //минимальный зум
            gMapControl1.MaxZoom = 16; //максимальный зум
            gMapControl1.Zoom = 4; // какой используется зум при открытии
            gMapControl1.Position = new GMap.NET.PointLatLng(50.4547, 30.5238);// точка в центре карты при открытии
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; // как приближает (просто в центр карты или по положению мыши)
            gMapControl1.CanDragMap = true; // перетаскивание карты мышью
            gMapControl1.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
            gMapControl1.ShowCenter = false; //показывать или скрывать красный крестик в центре
            gMapControl1.ShowTileGridLines = false; //показывать или скрывать тайлы

            createRoute.Visible = true;
            DeletePointOfRoute.Visible = false;
            SaveNewRoute.Visible = false;

            Init();
            
            listOfTransport.SelectedIndex = 0;
        }

        private void listOfRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearMap();
            if (listOfRoute.SelectedIndex > 0)
            {
                var route = listOfRoute.SelectedItem as Route;
                foreach (var point in route.RouteTransport)
                {
                    SetPointOnMap(point);
                }
            }
        }
        private void listOfTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listOfTransport.SelectedIndex > 0)
            {
                Transport transport = listOfTransport.SelectedItem as Transport;
                listOfRoute.SelectedIndex = route.FindIndex(x => x.Equals(transport.Route)) + 1;
                departurePoint.Text = transport.DeparturePoint;
                arrivalPoint.Text = transport.ArrivalPoint;
                price.Value = (decimal)((transport.Price <= 0.01) ? 0.01 : transport.Price);
            }
            else if (listOfTransport.SelectedIndex == 0)
            {
                listOfRoute.SelectedIndex = 0;
                departurePoint.Text = "";
                arrivalPoint.Text = "";
                price.Value = (decimal)0.01;
            }
        }
        private void UpdateDetail_Click(object sender, EventArgs e)
        {
            if(listOfTransport.SelectedIndex <= 0)
            {
                MessageBox.Show("Вкажіть транспорний засіб");
            }
            if(listOfRoute.SelectedIndex <= 0)
            {
                MessageBox.Show("Вкажіть маршрут транспорного засобу");
            }
            if (string.IsNullOrEmpty(departurePoint.Text))
            {
                MessageBox.Show("Вкажіть місце початку маршруту");
            }
            if (string.IsNullOrEmpty(arrivalPoint.Text))
            {
                MessageBox.Show("Вкажіть місце кінця маршруту");
            }
            if(price.Value < 0)
            {
                MessageBox.Show("Вкажіть вартість проїзду");
            }
            Transport transport = listOfTransport.SelectedItem as Transport;
            transport.PlanTrip(listOfRoute.SelectedItem as Route, 
                               departurePoint.Text, 
                               arrivalPoint.Text, 
                               (double)price.Value);
            MessageBox.Show("Успішне призначення поїздки для транспортного засобу");
        }
        private void DeleteRouteByTransport_Click(object sender, EventArgs e)
        {
            if(listOfTransport.SelectedIndex > 0)
            {
                Transport transport = listOfTransport.SelectedItem as Transport;
                transport.FinishTrip();
            }
        }

        private void createRoute_Click(object sender, EventArgs e)
        {
            //clear selected route
            listOfRoute.SelectedIndex = 0;

            ClearMap();

            createRoute.Visible = false;
            DeletePointOfRoute.Visible = true;
            SaveNewRoute.Visible = true;
        }
        private void SaveNewRoute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameRoute.Text))
            {
                MessageBox.Show("Вкажіть назву маршруту");
            }
            else
            {
                route.Add(new Route(nameRoute.Text, pointOfNewRoute));
                
                //clear selected route
                listOfRoute.SelectedIndex = 0;

                ClearMap();
                nameRoute.Text = "";
                updateListOfRoute();
            }
        }
        private void DeletePointOfRoute_Click(object sender, EventArgs e)
        {
            int index = listOfPoints.SelectedIndex;
            if(index >= 0)
            {
                var point = (PointLatLng)(listOfPoints.SelectedItem);
                gMapControl1.Overlays[0].Routes[0].Points.Remove(point);

                var marker = gMapControl1.Overlays[0].Markers.FirstOrDefault(x => x.Position == point);
                gMapControl1.Overlays[0].Markers.Remove(marker);

                gMapControl1.ZoomAndCenterMarkers("MainOverlay");

                pointOfNewRoute.RemoveAt(index);

                listOfPoints.Items.RemoveAt(index);
            }
        }
        private void gMapControl1_OnMapClick(PointLatLng pointClick, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && SaveNewRoute.Visible == true)
            {
                SetPointOnMap(pointClick);
            }
        }
        private void SetPointOnMap(PointLatLng pointClick)
        { 
            if (gMapControl1.Overlays.Count == 0)
            {
                gMapControl1.Overlays.Add(new GMapOverlay("MainOverlay"));
            }

            GMapMarker marker = new GMarkerGoogle(pointClick, GMarkerGoogleType.red);
            gMapControl1.Overlays[0].Markers.Add(marker);
            
            if (gMapControl1.Overlays[0].Routes.Count == 0)
            {
                gMapControl1.Overlays[0].Routes.Add(new GMapRoute("Новий маршрут"));
            }
            gMapControl1.Overlays[0].Routes[0].Points.Add(pointClick);
            gMapControl1.ZoomAndCenterRoutes("MainOverlay");

            listOfPoints.Items.Add(pointClick);
            pointOfNewRoute.Add(pointClick);
        }
        private void ClearMap()
        {
            pointOfNewRoute.Clear();
            //delete markers
            if(gMapControl1.Overlays.Count > 0)
            {
                gMapControl1.Overlays[0].Markers.Clear();
                gMapControl1.Overlays[0].Routes.Clear();
            }
            gMapControl1.Overlays.Clear();

            listOfPoints.Items.Clear();

            createRoute.Visible = true;
            DeletePointOfRoute.Visible = false;
            SaveNewRoute.Visible = false;
        }

        private void Init()
        {
            foreach (var t in typeOfTransportList)
                typeOfTransport.Items.Add(t.Key);
            foreach (var c in classOfTransportList)
                classOfTransport.Items.Add(c.Key);
            updateListOfTransport();
            updateListOfRoute();
        }
        private void updateListOfTransport()
        {
            listOfTransport.Items.Clear();
            listOfTransport.Items.Add("");
            foreach (var t in ViewDataForm.Transports)
            {
                listOfTransport.Items.Add(t);
            }
        }
        private void updateListOfRoute()
        {
            listOfRoute.Items.Clear();
            listOfRoute.Items.Add("");
            foreach (var r in route)
            {
                listOfRoute.Items.Add(r);
            }
        }

        private void createTransport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTransport.Text))
            {
                MessageBox.Show("Вкажіть назву транспорного засобу");
            }
            if(typeOfTransport.SelectedIndex < 0)
            {
                MessageBox.Show("Вкажіть тип транспорного засобу");
            }
            if(classOfTransport.SelectedIndex < 0)
            {
                MessageBox.Show("Вкажіть клас транспорного засобу");
            }
            if(numberOfSeats.Value <= 0)
            {
                MessageBox.Show("Вкажіть кількість місць у транспорному засобі");
            }
            ViewDataForm.Transports.Add(new Transport(nameTransport.Text,
                typeOfTransportList[typeOfTransport.SelectedItem.ToString()],
                classOfTransportList[classOfTransport.SelectedItem.ToString()],
                (int)(numberOfSeats.Value)));
            updateListOfTransport();
            MessageBox.Show("Успішне додання транспортного засобу");
        }

        private void AddDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Route.Export(route, PATH_ROUTE);
            Transport.Export(ViewDataForm.Transports, ViewDataForm.PATH_TRANSPORT);
        }
        
        private void listOfPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listOfPoints.SelectedIndex >= 0)
            {
                var point = (PointLatLng)listOfPoints.SelectedItem;
                gMapControl1.Position = point;
            }
        }
    }
}
