namespace Objects_Olivia_Babcock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define myComputer and writes to the console.
            Computer myComputer = new Computer("Toshiba", "Satellite", true);
            IBootUp myBootUp = myComputer;
            Console.WriteLine(myComputer.Equals(myBootUp));

            // Defines myOtherComputer and writes to the console.
            Computer myOtherComputer = new Computer("Toshiba", "Satellite", true);
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            // Defines and sets string values equal
            string myString = myComputer.ToString();
            string myOtherString = myString;

            // Defines myString 
            myString = "Hi!";

            // Prints to the console 
            Console.WriteLine(myString);
            Console.WriteLine(myOtherString);

            // Prints to the console
            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString());

            // Prints to the console
            Console.WriteLine(myComputer.GetType());
            Console.WriteLine(myBootUp.GetType());

            // Defines PowerOnOf
            myOtherComputer.PowerOnOff();

            // Prints to the console
            Console.WriteLine(myString == myOtherComputer.ToString());
            Console.WriteLine(myString);
            Console.WriteLine(myOtherComputer.ToString());

            // Prints to the console
            Console.WriteLine(myString.Contains('i'));

            // Prints to the console and uppercases myString
            Console.WriteLine(myString.ToUpper());
        }
    }
}