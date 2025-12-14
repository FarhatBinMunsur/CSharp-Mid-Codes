using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car c1 = new Car();
            c1.Model = "A19";
            //Console.WriteLine(c1.Model);

            Car c2 = new Car(1, "Allion", "Toyota", 5000, 4, true);
            Console.WriteLine("Car Info: ");
            c2.ShowInfo();
            //c2.CheckPremiumVehicle();

            Vehicle b1 = new Bike(2, "R15", "Yamaha", 1500, true, 300);
            Console.WriteLine("Bike Info: ");
            b1.ShowInfo();

            
        }
    }
}
