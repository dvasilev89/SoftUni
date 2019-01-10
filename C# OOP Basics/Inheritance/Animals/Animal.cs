using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {        
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value == null)
                {
                    throw new Exception("Invalid input!");
                }

                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                age = value;
            }
        }

        public string Gender
        {
            get { return gender; }
            private set
            {
                if (value == null)
                {
                    throw new Exception("Invalid input!");
                }

                gender = value;
            }
        }

        public virtual void ProduceSound()
        {
            Console.WriteLine("Hi!");
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Gender}";
        }
    }
}
