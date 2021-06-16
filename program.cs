using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace ip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Pinger";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(ip);
        }

          public static string ip()
          {
            WebClient kek = new WebClient();
            string ip = kek.DownloadString("https://api.ipify.org/?format=text");
            return ip;
          }

    }
}
