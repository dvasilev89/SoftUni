using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> persons;

        public Family()
        {
            this.Persons = new List<Person>();
        }

        public List<Person> Persons
        {
            get { return this.persons; }
            set { this.persons = value; }
        }

        public void AddMember(Person member)
        {
            if (member == null)
            {
                throw new Exception();
            }

            this.Persons.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.Persons.OrderByDescending(x => x.Age).FirstOrDefault();
        }        
    }
}
