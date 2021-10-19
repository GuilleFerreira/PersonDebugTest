using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, string bday)
        {
            this.Name = name;
            this.ID = id;
            this.Bday = bday;
        }

        private string name;

        private string id;

        private string bday;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public string Bday
        {
            get{return this.bday;}
            set
            {
                if (Cumple.IsValid(value))
                {
                    this.bday = value;
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID} y mi fecha de nacimiento {this.Bday}");
        }
    }
}
