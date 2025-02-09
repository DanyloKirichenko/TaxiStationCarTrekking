using GMap.NET;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace TaxiStationCarTrekking
{
    public class Transport
    {
        public string Name { get; }
        public string Number { get; private set; }
        public TypeOfTransport TypeOfTransport { get; }
        public ClassOfTransport ClassOfTransport { get; }

        public PointLatLng CurrentPosition { get; set; } 
        public Route Route { get; private set; } = null;
        public bool IsAvailable { get; private set; }//доступно для работы транспортное средство

        public string DeparturePoint { get; private set; } = "";
        public string ArrivalPoint { get; private set; } = "";

        public double Price { get; private set; }

        public bool PlanTrip(Route Route, string DeparturePoint, string ArrivalPoint, double Price)
        {
            if(Route.RouteTransport.Count < 2 || 
               string.IsNullOrEmpty(DeparturePoint) ||
               string.IsNullOrEmpty(ArrivalPoint) ||
               Price < 0)
            {
                return false;
            }
            IsAvailable = true;
            this.Route = Route;
            this.DeparturePoint = DeparturePoint;
            this.ArrivalPoint = ArrivalPoint;
            this.Price = Price;
            return true;
        }
        public void FinishTrip()
        {
            IsAvailable = false;
            this.Route = null;
            this.DeparturePoint = "";
            this.ArrivalPoint = "";
            this.Price = 0;
        }
        
        public int NumberOfSeats { get; }
        public int NumberOfFreeSeats { get; private set; }
        public void ReserveFreeSeat(int numberSeats)
        {
            if(numberSeats <= NumberOfFreeSeats)
            {
                NumberOfFreeSeats -= numberSeats;
            }
        }

        public Transport(string Name, 
                         TypeOfTransport TypeOfTransport, 
                         ClassOfTransport ClassOfTransport, 
                         int NumberOfSeats)
        {
            IsAvailable = false;
            this.Name = Name;
            this.TypeOfTransport = TypeOfTransport;
            this.ClassOfTransport = ClassOfTransport;
            this.NumberOfSeats = NumberOfSeats;
            NumberOfFreeSeats = NumberOfSeats;
            this.Number = NumberControl();

            RandomPosition();
        }

        [JsonConstructor]
        public Transport(string Name,
                         string Number,
                         TypeOfTransport TypeOfTransport,
                         ClassOfTransport ClassOfTransport,
                         int NumberOfSeats,
                         int NumberOfFreeSeats,
                         PointLatLng CurrentPosition,
                         Route Route,
                         bool IsAvailable,
                         string DeparturePoint,
                         string ArrivalPoint,
                         double Price)
        {
            this.Name = Name;
            this.Number = NumberControl(Number);
            this.TypeOfTransport = TypeOfTransport;
            this.ClassOfTransport = ClassOfTransport;
            this.NumberOfSeats = NumberOfSeats;
            this.NumberOfFreeSeats = NumberOfFreeSeats;
            this.CurrentPosition = CurrentPosition;
            this.Route = Route;
            this.IsAvailable = IsAvailable;
            this.DeparturePoint = DeparturePoint;
            this.ArrivalPoint = ArrivalPoint;
            this.Price = Price;

            RandomPosition();
        }

        private void RandomPosition()
        {
            var nullPoint = new PointLatLng(0, 0);
            if (CurrentPosition == null || CurrentPosition == nullPoint)
            {
                CurrentPosition = new PointLatLng(49.998055, 36.688888);//координаты таксопарка
            }
            else
            {
                if(Route != null)
                {
                    if (Route.RouteTransport.Count > 0)
                    {
                        Random rnd = new Random();
                        CurrentPosition = Route.RouteTransport[rnd.Next(Route.RouteTransport.Count)];
                    }
                }
            }
        }

        public override string ToString()
        {  
            return Name + "(" + Number + ")";
        }

        public string ShowDetails()
        {
            string typeT = "", classT = "";
            switch (TypeOfTransport)
            {
                case TypeOfTransport.Bus:
                    typeT = "автобус";
                    break;
                case TypeOfTransport.Car:
                    typeT = "легковий автомобіль";
                    break;
                default:
                    typeT = "не встановлено";
                    break;
            }

            switch (ClassOfTransport)
            {
                case ClassOfTransport.Economy:
                    classT = "економ";
                    break;
                case ClassOfTransport.Premium:
                    classT = "преміум";
                    break;
                case ClassOfTransport.Standard:
                    classT = "стандарт";
                    break;
                default:
                    classT = "не встановлено";
                    break;
            }

            return "Назва: " + (Name ?? "-") + "\n" +
                   "Номер: " + Number + "\n" +
                   "Тип транспорту: " + typeT + "\n" +
                   "Клас транспорту: " + classT + "\n" +
                   "Статус: " + (IsAvailable == false ? "не доступний" : "доступний") + " для поїздки\n" +
                   (IsAvailable == true ? "вартість проїзду " + Price + "грн.\n" : "") +
                   "Кількість місць: " + NumberOfSeats + "\n" +
                   "Кількість вільних місць: " + NumberOfFreeSeats + "\n";
        }
        private string NumberControl(string value = null)
        {
            string pattern = @"^[ABCEHIKMOPTX]{2}(?!0{4})\d{4}[ABCEHIKMOPTX]{2}$";
            string _value = value;
            if (value == null || value.Length != 8 || !Regex.IsMatch(value, pattern))
            {
                string letters = "ABCEHIKMOPTX";
                Random rnd = new Random();

                string number = "";
                string tmp = "";

                for (int i = 0; i < 2; i++)
                {
                    tmp += letters[rnd.Next(0, letters.Length)];
                }
                number += tmp; tmp = "";

                for (int i = 0; i < 3; i++)
                {
                    tmp += rnd.Next(0, 10);
                }
                tmp += (tmp.Equals("000")) ? rnd.Next(1, 10) : rnd.Next(0, 10);
                number += tmp; tmp = "";

                for (int i = 0; i < 2; i++)
                {
                    tmp += letters[rnd.Next(0, letters.Length)];
                }
                return (number + tmp).ToUpper();
            }
            else
            {
                return value;
            }
        }

        public static List<Transport> Import(string fileName)
        {
            List<Transport> tranport = new List<Transport>();
            if (File.Exists(fileName))
            {
                try
                {
                    string jsonString = File.ReadAllText(fileName);
                    tranport = JsonConvert.DeserializeObject<List<Transport>>(jsonString);
                }
                catch
                {
                    throw new Exception("Проблема у даних файлу");
                }
            }
            return tranport;
        }
        public static void Export(List<Transport> tranport, string fileName)
        {
            string content = JsonConvert.SerializeObject(tranport, Formatting.Indented);
            File.WriteAllText(fileName, content);
        }
    }
    public enum TypeOfTransport
    {
        Car, Bus
    }
    public enum ClassOfTransport
    {
        Standard, Premium, Economy
    }
}
