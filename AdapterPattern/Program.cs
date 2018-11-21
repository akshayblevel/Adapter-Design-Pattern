using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Adapter();
            List<string> developers = target.GetDeveloperList();

            Console.WriteLine("######### Developer List ##########");
            foreach (var item in developers)
            {
                Console.Write(item);
            }

            Console.ReadKey();
        }
    }
}
