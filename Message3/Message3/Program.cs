using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notification[] n = new Notification[] { new EmailNotification("Strange@marvels.com"), new SMSNotification("+8801711000000"), new SMSNotification("+8801711000001") };

            foreach(Notification n2 in n){
                n2.Send();
                
            }   
        }
    }
}
