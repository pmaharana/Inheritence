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
            Robot robot2 = new Robot()
            {
                Name = "Wall-E",
                TerminatorStatus = false,
                Age = 1073
            };
            Robot gundam = new Robot()
            {
                Name = "Wing Zero",
                TerminatorStatus = false,
                Age = 42
            };

            Console.WriteLine($"Hello, my name is {robot1.Name}");
            robot1.IsATerminator();

            Human human1 = new Human()
            {
                Name = "YUGIOOOOHHH",
                IsAsleep = true
            };
            Human ash = new Human()
            {
                Name = "Ash Ketchum",
                Food = "Rice balls",
                IsAsleep = false,
                Age = 11
            };


            human1.Eat("quesadilla");

            Console.WriteLine(human1.DisplayGreeting());

            human1.IsUserAsleep();

            human1.WakeUp();

            human1.IsUserAsleep();

            Panda panda1 = new Panda()
            {
                Name = "Chen Stormstout",
                IsAsleep = true,
                Age = 65
            };
            Console.WriteLine(panda1.DisplayGreeting());
            panda1.Eat("bamboo");
            panda1.IsUserAsleep();
            panda1.WakeUp();
            panda1.IsUserAsleep();

            Panda panda2 = new Panda()
            {
                Name = "Pandarean Brewmaster",
                Food = "coconut",
                IsAsleep = true,
                Age = 33
            };

            List<Human> humanList = new List<Human>();
            humanList.Add(human1);
            humanList.Add(ash);

            foreach (var x in humanList)
            {
                Console.WriteLine($"{x.Name}");
            }

            human1.DisplayType();



        }
    }
}
