using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    public class Robot
    {
        public string Name { get; set; }


        public string DisplayName()  //display name method
        {
            return this.Name;
        }

        public string DisplayGreeting()  //Display greeting method
        {
            return ($"Hello, my name is {DisplayName()}");
        }
        public void StartUp()
        {
            Console.WriteLine("..Starting up system");
        }
        public void ShutDown()
        {
            Console.WriteLine("Shutting down...");
        }


    }
}
