using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot1 = new Robot()
            {   Name = "MechaGodzilla",
                TerminatorStatus = true
            };
            

            Console.WriteLine($"Hello, my name is {robot1.Name}");
            robot1.IsATerminator();
        }
    }
}
