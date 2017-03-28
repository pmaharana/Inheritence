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
        public bool TerminatorStatus { get; set; }


        //public string DisplayName(string name)  //display name method
        //{
        //    name = this.Name;
        //    return this.Name;
        //}

        public void DisplayGreeting()  //Display greeting method
        {

            //Console.WriteLine($"Hello, my name is {DisplayName()}");
        }
        public void StartUp()
        {
            Console.WriteLine("..Starting up system");
        }
        public void ShutDown()
        {
            Console.WriteLine("Shutting down...");
        }

       public void IsATerminator()
        {
            bool termstatus = this.TerminatorStatus;
            if (termstatus)
            {
                Console.WriteLine("This is a terminator!");
            } 
            else
            {
                Console.WriteLine("This is NOT a terminator");
            }
        }
        

    }
}
