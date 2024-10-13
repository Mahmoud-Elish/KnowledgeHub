using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.VehicleControlSystem;

public abstract class Vehicle
{
    public void Stop()
    {
        Console.WriteLine("Vehicle Stopped");
    }
    public void Start()
    {
        Console.WriteLine("Vehicle Started");
    }
    public abstract void Describe();
}
