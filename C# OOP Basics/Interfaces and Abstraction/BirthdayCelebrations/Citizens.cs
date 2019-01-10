using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizens : IId, IBirthdate, IName
    {
        private string id;
        private string name;
        private string age;


        public Citizens(string name, string age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null);
        }
        public DateTime Birthdate { get; set; }

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
