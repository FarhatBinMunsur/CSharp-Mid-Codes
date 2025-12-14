using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Message3
{
    internal class Notification
    {
        public Notification() { }

        public virtual string Message() {
            return "Generic notification";
        }

        public void Send() {
            Console.WriteLine(Message());
        }

        
    }
}
