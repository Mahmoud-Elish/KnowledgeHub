using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.MediaPlayerPlugins;

public class Video : IMedia
{
    public void Play()
    {
        Console.WriteLine("Video Play");
    }

    public void Stop()
    {
        Console.WriteLine("Video Stop");
    }
}
