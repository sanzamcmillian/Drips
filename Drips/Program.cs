using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drips
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("How often do you hear drops of water(in seconds)?");
            String s1 = Console.ReadLine();
            //calculation
            Double n = Double.Parse(s1);
            Double hour = (3600 / n) * (0.00025), day = (86400 / n) * (0.00025),week = (604800 / n)*(0.00025);
            //results
            String resulth = String.Format("This wastes {1} litres of water every hour",n,hour,day,week);
            Console.WriteLine(resulth);
            String resultd = String.Format("This wastes {2} litres of water every day", n, hour,day,week);
            Console.WriteLine(resultd);
            String resultw = String.Format("This wastes {3} litres of water every week", n, hour,day,week);
            Console.WriteLine(resultw);


            string kea = Console.ReadLine();
        }
    }
}
