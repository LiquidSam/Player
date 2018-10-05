using System;

public class AudioPlayer2
{
    private int _Volume;
    public int Volume
    {
        get
        {
            return _Volume;
        }
        set
        {
            if (value < 0) _Volume = 0;
            else if (value > 100) _Volume = 100;
            else _Volume = value;
        }
    }
    Song[] songs;
}
