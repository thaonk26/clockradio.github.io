using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Radio
{
    class clockRadio
    {


        public string timeOfDay()
        {
            Console.WriteLine("Please enter in the time: \r\n Hour:");
            int Hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minutes:");
            int Minutes = Convert.ToInt32(Console.ReadLine());
            return Hours + ":" + Minutes;
        }

        public double radioStation()
        {
            Console.WriteLine("Please enter a radio station: (ie: 101.9)");
            double radioChannel = double.Parse(Console.ReadLine());
            return radioChannel;
        }

        public int volume()
        {
            Console.WriteLine("From 0-20, what would you like the volume to be Sir?");
            int volume = int.Parse(Console.ReadLine());
            return volume;
        }

    
    }
}
