using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GetPhoto
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            string html =wc.DownloadString(@"https://www.microsoft.com/en-ca/store/collections/Keyboardsmiceandstyluses/pc?cat0=devices&icid=PC_acc_CP2_keyboardsmiceandstyluses_07162018-en-ca");

           MatchCollection mc= Regex.Matches(html, @"<img.+?\ssrc=\W(https://img.+?true)");

            foreach (Match item in mc)
            {
                if (item.Success)
                {
                    Console.WriteLine(item.Groups[1].Value);
                }
               
            }
            Console.ReadKey();
        }
    }
}
