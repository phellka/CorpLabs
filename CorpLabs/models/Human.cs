using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorpLabs.models
{
    public class Human
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public override string ToString()
        {
            return "Id = " + Id.ToString() + " " +
                "Age = " + Age.ToString() + " " +
                "Name = " + Name + " " +
                "Surname = " + Surname;
        }
    }
}
