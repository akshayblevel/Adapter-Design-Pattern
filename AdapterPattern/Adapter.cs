using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public class Adapter: Adaptee, ITarget
    {
        public List<string> GetDeveloperList()
        {
            List<string> developerList = new List<string>();
            string[][] developers = GetDevelopers();
            foreach (string[] developer in developers)
            {
                developerList.Add(developer[0]);
                developerList.Add(",");
                developerList.Add(developer[1]);
                developerList.Add(",");
                developerList.Add(developer[2]);
                developerList.Add("\n");
            }
            return developerList;
        }
    }
}
