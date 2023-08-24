using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Olivia_Babcock
{
    internal class Computer : IBootUp
    {   // Defines get and set for information about the computer.
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        // Defines paramater values
        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        // Calls PowerOnOff method
        public void PowerOnOff()
        {  
            // Creates a bool
            IsOn = !IsOn;

            // Creates an if and else statement for whether the computer is on.
            if(IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }

        // Calls ToString method
        public override string ToString()
        {   // Prints line to the console
            return $"The computer is made by {Brand} and is a {Type} computer, it is on: {IsOn}!";
        }
    }
}
