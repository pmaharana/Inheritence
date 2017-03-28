using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    public class Panda
    {
        public string Name { get; set; }
        public string Food { get; set; }

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
            Console.WriteLine($"Yum, I that some good {food}");
        }
        public void GoToSleep()          //Go to sleep method
        {

        }
        public void WakeUp()                //Wake up method
        {

        }

    }
}
