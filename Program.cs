using System;

namespace Objects_Stretch_Zachory
{
    class Program
    {
        //all of this prints everything I worked on 
        static void Main(string[] args)
        {
            Computer myComputer = new Computer("Apple", "All-in-one", true);
            IBootUp myBootUp = myComputer;
            Console.WriteLine(myComputer.Equals(myBootUp));

            Computer myOtherComputer = new Computer("Apple", "All-in-one", true);
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            string myString  = myComputer.ToString();
            string myOtherString = myString;

            myString = "Hi!";

            Console.WriteLine(myString);
            Console.WriteLine(myOtherString);


            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString());

            Console.WriteLine(myComputer.GetType());
            Console.WriteLine(myBootUp.GetType());

            myOtherComputer.PowerOnOff();

            Console.WriteLine(myString == myOtherComputer.ToString());
            Console.WriteLine(myString);
            Console.WriteLine(myOtherComputer.ToString());

            Console.WriteLine(myString.Contains('i'));
            
            Console.WriteLine(myString.ToUpper());
        }
    }
}