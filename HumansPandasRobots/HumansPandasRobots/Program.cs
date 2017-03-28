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

            Human human1 = new Human()
            {
                Name = "YUGIOOOOHHH",
                IsAsleep = true
            };


            human1.Eat("quesadilla");

            Console.WriteLine(human1.DisplayGreeting());

            human1.IsUserAsleep();

            human1.WakeUp();

            human1.IsUserAsleep();

            Panda panda1 = new Panda()
            {
                Name = "Chen Stormstoud",
                IsAsleep = false,
                Age = 65
            };
            Console.WriteLine(panda1.DisplayGreeting());
            panda1.Eat("bamboo");
            panda1.WakeUp();
            panda1.IsUserAsleep();




        }
    }
}
