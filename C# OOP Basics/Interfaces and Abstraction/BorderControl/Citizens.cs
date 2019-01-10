using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizens : IId
    {
        private string id;
        private string name;
        private string age;

        public Citizens(string id, string name, string age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public string Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
