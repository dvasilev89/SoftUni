using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Pet : IBirthdate, IName
    {
        public string Name { get; set; }

        public DateTime Birthdate { get; set; }
       

        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null);
        }
    }
}
