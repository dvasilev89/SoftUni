using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Robots : IId
    {
        private string id;
        private string model;

        public Robots(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
