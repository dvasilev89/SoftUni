using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : IDrive
    {
        private string driver;

        public string Car { get => "Ferrari"; }
        public string Model { get => "488-Spider"; }

        public Ferrari(string driver)
        {
            Driver = driver;
        }

        public string Driver
        {
            get { return driver; }
            set { driver = value; }
        }

        public string PushTheGasPedal()
        {
            return "Zadu6avam sA!";
        }

        public string UseBrake()
        {
            return "Brakes!";
        }
    }
}
