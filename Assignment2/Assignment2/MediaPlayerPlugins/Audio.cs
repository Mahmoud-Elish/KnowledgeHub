using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.MediaPlayerPlugins;

public class Audio : IMedia
{
    public void Play()
    {
        Console.WriteLine("Audio Play");
    }

    public void Stop()
    {
        Console.WriteLine("Audio Stop");
    }
}
