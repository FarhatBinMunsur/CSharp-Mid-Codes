using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    internal class Car:Vehicle
    {
        protected int numberofDoors;
        protected bool isLuxury;

        public int NumberofDoors
        {
            get { return numberofDoors; }
            set 
            {
                if (value > 4)
                {
                    Console.WriteLine("Invalid number of doors");
                    return;
                }
                numberofDoors = value;
            }
        }

        public bool IsLuxury
        {
            get { return isLuxury; } 
            set { isLuxury = value; }
        }

        public Car() { }
        public Car(int vehicleID, string model, string brand, double dailyRate, int numberofDoors, bool isLuxury):base(vehicleID,model,brand,dailyRate)
        {
            this.numberofDoors = numberofDoors;
            this.isLuxury = isLuxury;

        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Number of Doors: "+this.numberofDoors);
            Console.WriteLine("IS Luxury :" + this.isLuxury);
            this.CheckPremiumVehicle();
        }
        public void CheckPremiumVehicle()
        {
            if (isLuxury && dailyRate > 3000) Console.WriteLine("Premium Car.");
            else Console.WriteLine("Not Premium Car.");
        }
    }
}
