using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfSayHello
{
    public class Wishes
    {
        public string GetWishes(string name)
        {
            var src = DateTime.Now;
            var hrs=src.Hour;
            string greet = string.Empty;
            string gretMessage = string.Empty;
            if (hrs < 12)
            {
                greet = "Good Morning";
            }
            else if (hrs >= 12 && hrs <= 17)
            {
                greet = "Good Afternoon";
            }
            else if (hrs >= 17 && hrs <= 24)
            {
                greet = "Good Evening";
            }
            gretMessage = greet + "," + name;

            return gretMessage;
        }
        public string GetGreetWishes(string name)
        {
            
            string gretMessage = string.Empty;
            gretMessage = "Happy weekend" + "," + name;

            return gretMessage;
        }
    }
}