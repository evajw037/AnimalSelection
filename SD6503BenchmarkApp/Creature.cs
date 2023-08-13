using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD6503BenchmarkApp
{
    public class Creature
    {
        private string creatureName;
        private string age;
        private string owner;

        public string CreatureName { get => creatureName; set => creatureName = value; }
        public string Age { get => age; set => age = value; }
        public string Owner { get => owner; set => owner = value; }

        public Creature()
        {
            CreatureName = "NA";
            Age = "0";                                                        //Slide P42
            Owner = "NA";

        }
        public override string ToString()
        {
            return CreatureName + "Age:" + Age + "(" + Owner + ")";
        }

    }
}
