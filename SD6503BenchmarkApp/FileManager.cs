using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SD6503BenchmarkApp
{
    public class FileManager
    {

        public List<Creature> LoadCreatures()
        {
            try
            {
                List<Creature> creatureList = new List<Creature>();
                StreamReader sr = new StreamReader("Creatures.txt");

                while (!sr.EndOfStream)                                     //slide P45
                {
                    string temp = sr.ReadLine();
                    string[] value = temp.Split(',');

                    Creature c = new Creature();
                    c.CreatureName = value[0];
                    c.Age = value[1]; 
                    c.Owner = value[2];

                    creatureList.Add(c);
                }
                sr.Dispose();
                return creatureList;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public bool SaveCreature(Creature c, string fileName)            //slide P47
        {

            try
            {
                StreamWriter sw = new StreamWriter(fileName);

                sw.WriteLine("CREATURE DETAILS");
                sw.WriteLine("Creature Name: " + c.CreatureName);
                sw.WriteLine("Creature Age: " + c.Age);
                sw.WriteLine("Creature Owner: " + c.Owner);

                sw.Dispose();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
    }


}
