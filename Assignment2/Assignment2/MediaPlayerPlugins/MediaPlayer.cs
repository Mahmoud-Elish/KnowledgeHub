using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.MediaPlayerPlugins;

public class MediaPlayer(IMedia _media)
{
    public void Play()
    {
        _media?.Play();
    }

    public void Stop()
    {
        _media?.Stop();
    }
}
