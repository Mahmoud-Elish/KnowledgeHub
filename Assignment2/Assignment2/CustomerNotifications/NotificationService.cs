using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.CustomerNotifications;

public class NotificationService(INotification _notification)
{
    public void Notify(string message)
    {
        _notification.SendMessage(message);
    }
}
