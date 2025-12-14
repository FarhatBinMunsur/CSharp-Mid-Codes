using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message3
{
    internal class EmailNotification:Notification
    {
        public string Email { get; set; }
        public EmailNotification(string email) {
            this.Email = email;
        }

        public override string Message() { 
            base.Message();
            return "Email sent to" + Email;
        }
    }
}
