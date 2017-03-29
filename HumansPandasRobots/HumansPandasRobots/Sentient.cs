using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    public class Sentient
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public bool IsAsleep { get; set; }
        public int Age { get; set; }
        

        public string DisplayName()  //display name method
        {
            return this.Name;
        }

        public string DisplayGreeting()  //Display greeting method
        {
            return ($"Hello, my name is {DisplayName()}");
        }

        public void Eat(string food)    //Eat method
        {
            this.Food = food;
            Console.WriteLine($"Yum, I ate some good {food}");
        }
        public bool GoToSleep()          //Go to sleep method
        {
            Console.WriteLine($"{DisplayName()} is going to sleep");
            this.IsAsleep = true;
            return this.IsAsleep;
        }
        public bool WakeUp()                //Wake up method
        {
            Console.WriteLine($"{DisplayName()} is now going to wake up.");
            this.IsAsleep = false;
            return this.IsAsleep;
        }
        public void IsUserAsleep()    //check the sleep status of user
        {
            bool sleepstatus = this.IsAsleep;
            if (IsAsleep)
            {
                Console.WriteLine($"{DisplayName()} is asleep");
            }
            else
            {
                Console.WriteLine($"{DisplayName()} is awake");
            }
        }
        public void DisplayType()
        {
            Console.WriteLine($"Your type is {GetType().Name}");
        }


    }
}
