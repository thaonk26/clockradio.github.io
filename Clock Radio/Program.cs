using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Radio
{
    class Program
    {
        static void Main(string[] args)
        {
            string setTime;
            double setStation;
            int setVolume;

            clockRadio Clock_Radio = new clockRadio(); //this is an instance of the class

            setTime = Clock_Radio.timeOfDay();
            setStation = Clock_Radio.radioStation();
            setVolume = Clock_Radio.volume();

            Console.WriteLine("The current time is {0}\r\n You have set your current volume at {1}\r\n So you like listening to {2} eh? Never heard of it... ", setTime, setVolume, setStation);







            //Console.WriteLine("Please enter the time: ");
            //Console.WriteLine("Hour");
            //hour = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Minutes");
            //minutes = Convert.ToInt32(Console.ReadLine());

            //double radioStation;
            //Console.WriteLine("What radio station would you like to listen to? (ie: 101.9)");
            //radioStation = double.Parse(Console.ReadLine());

            //int volume;
            //Console.WriteLine("From 0-20, what would you like your volume at Sir?");
            //volume = int.Parse(Console.ReadLine());




        }
    }
}
