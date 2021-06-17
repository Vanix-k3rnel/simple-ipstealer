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
            // Console color
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            // going to the string that will get the ip. and write the ip to console
            Console.WriteLine(ip);
            Console.Readline();
            
            
            
            
            
            
        }

          public static string ip()
          {
            WebClient kek = new WebClient();
            string ip = kek.DownloadString("https://api.ipify.org/?format=text");
            return ip;
          }

    }
}
