using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_Stretch_Zachory
{
    //creates a lot of variables for the computer being on, the brand, and its type.
    class Computer : IBootUp
    {
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        public void PowerOnOff()
        {
            // Writes True or False statements and what would be printed to the screen depending on the outcome.
            IsOn = !IsOn;

            if(IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }
        // creates a variable or  string (I forgot) that will print a sentence to the screen telling the user what brand and type a computer is. It also tells if it is on or not.
        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a(n) {Type} computer, it is on: {IsOn}!";
        }
    }
}
