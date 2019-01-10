using System;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ICall, IBrowse
    {
        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(Char.IsDigit))
            {
                return "Invalid number!";
            }

            return $"Calling... {phoneNumber}";
        }

        public string Browse(string webSite)
        {
            if (webSite.Any(Char.IsDigit))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {webSite}!";
        }
    }
}
