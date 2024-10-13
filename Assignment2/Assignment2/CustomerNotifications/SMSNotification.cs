using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.CustomerNotifications;

public class SMSNotification : INotification
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"This Message via SMS : {message}");
    }
}
