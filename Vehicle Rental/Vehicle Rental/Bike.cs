using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    internal class Bike:Vehicle
    {
        bool hasCarrier;
        int engineCC;

        public bool HasCarrier
        {
            get { return hasCarrier; }
            set { hasCarrier = value; }
        }

        public int EngineCC
        {
            get { return engineCC; }
            set { engineCC = value; }
        }

        public Bike() { }

        public Bike(int vehicleID,string model,string brand,double dailyRate,bool hasCarrier,int engineCC):base(vehicleID,model,brand,dailyRate)        
        {
            this.hasCarrier = hasCarrier;
            this.engineCC = engineCC;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Has Carrier: "+this.hasCarrier);
            Console.WriteLine("Engine CC: " + this.engineCC);
            this.CheckPremiumVehicle();
        }

        public void CheckPremiumVehicle() { 
            if(dailyRate>1000 && engineCC>250) Console.WriteLine("Premium Bike.");
            else Console.WriteLine("Not Premium Bike.");
        }

        

    }
}
