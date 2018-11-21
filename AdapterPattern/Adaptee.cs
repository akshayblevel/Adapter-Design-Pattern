using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public class Adaptee
    {
        public string[][] GetDevelopers()
        {
            string[][] Developers = new string[4][];
            Developers[0] = new string[] { "100", "Akshay", "Team Leader" };
            Developers[1] = new string[] { "101", "Nachiket", "Developer" };
            Developers[2] = new string[] { "102", "Kaushal", "Designer" };
            Developers[3] = new string[] { "103", "Jignesh", "IT Manager" };
            return Developers;
        }
    }
}
