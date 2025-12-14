using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    internal class Vehicle
    {
        protected int vehicleID;
        protected string model;
        protected string brand;
        protected double dailyRate;

        public int VehicleID
        {
            get { return vehicleID; }
            set { vehicleID = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Brand 
        {
            get { return brand; }
            set { brand = value; }
        }

        public double DailyRate 
        { 
            get { return dailyRate; }
            set { dailyRate = value; }
        }
        public Vehicle() { }

        public Vehicle(int vehicleID, string model, string brand, double dailyRate)
        { 
            this.vehicleID = vehicleID;
            this.model = model;
            this.brand = brand;
            this.dailyRate = dailyRate;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Vehicle ID: " + vehicleID);
            Console.WriteLine("Vehicle Model: "+model);
            Console.WriteLine("Brand: "+brand);
            Console.WriteLine("Daily Rate: "+dailyRate);

        }

    }
}   
