using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message3
{
    internal class SMSNotification:Notification
    {
        private string number;

        public SMSNotification() { }
        public SMSNotification(string number) {
            this.number = number;
        }

        public override string Message() {
            base.Message();
            return "SMS sent to " + number;
        }

    }
}
