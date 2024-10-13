using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.CustomerNotifications;

public interface INotification
{
    void SendMessage(string message);
}
