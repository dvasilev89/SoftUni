using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robots : IId
    {
        private string id;
        private string model;

        public Robots(string id, string model)
        {
            Id = id;
            Model = model;
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
