using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
   public class Program
    {
        static void Main(string[] args)
        {
            var player = new AudioPlayer2();
            player.Volume = 300;
            Console.WriteLine(player.Volume);
            Console.ReadLine();

        }
       
    }
}
