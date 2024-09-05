using System;

namespace Calc_Opdrachten
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Un Comment one by one to test each task ---
            // OpdrachtCalc1();
            OpdrachtCalc2();
            // OpdrachtCalc3();
        }

        public static void OpdrachtCalc1()
        {
            /* --- Opdracht 1 ---
                - Maak een class SomInt die twee gehele getallen optelt en het resultaat bewaart en opslaat
                - MAAR als je een SomInt maakt met maar 1 getal dan bewaart hij alleen dat getal
                - Maak een programma dat de gebruiker vraagt om 2 getallen en die laat optellen door SomInt
                - Het programma laat de uitkomst vervolgens zien op een beetje mooie manier
            */

            SomInt oneNumber = new SomInt(10);
            Console.WriteLine($"This is only one number: {oneNumber.Value}");

            int number1;
            int number2;

            // If no string is read in the input, then it returns null, so it gives an error.
            // Use TryParse with an if to do a check.
            Console.WriteLine("1st number:");
            if(!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Please enter a integer number.");
                return;
            }
            Console.WriteLine("2nd number:");
            if(!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Please enter a integer number.");
                return;
            }

            // Constructor
            SomInt result = new SomInt(number1, number2);

            // Calculate in the Class SomInt
            Console.WriteLine($"{number1} and {number2} is result: {result.Value}");
        }

        public static void OpdrachtCalc2()
        {
            /* --- Opdracht Calc 2 ---
                - Breidt het programma uit zodat class SomInt ook twee SomInts kan optellen
                - Zorg dat dat kan door de ‘plus’ operator te gebruiken 
                - Maak een programma dat de gebruiker vraagt om 2 getallen en die laat optellen door SomInts
                - Tel nog 2 getallen op
                - Tel vervolgens de uitkomsten bij elkaar op
                - Het programma laat de uitkomst vervolgens zien op een beetje mooie manier
            */

            // If no string is read in the input, then it returns null, so it gives an error.
            // Use TryParse with an if to do a check.
            Console.WriteLine("1st number:");
            if (!int.TryParse(Console.ReadLine(), out int number1))
            {
                Console.WriteLine("Please enter a integer number.");
                return;
            }
            Console.WriteLine("2nd number:");
            if(!int.TryParse(Console.ReadLine(), out int number2))
            {
                Console.WriteLine("Please enter a integer number.");
                return;
            }

            new SomInt(10,10);
            //Console.WriteLine($"Samen {new SomInt(10).Value}");

            // Calculate in the Class SomInt
            SomInt somInt1 = new SomInt(number1, number2);
            Console.WriteLine($"{number1} and {number2} is result: {somInt1.Value}");

            SomInt somInt2 = new SomInt(number1, number2);
            Console.WriteLine($"{number1} and {number2} is result: {somInt2.Value}");

            // SomInts addition together
            Console.WriteLine("--- This is the two SomInt's addition to each other ---");
            SomInt somIntsTogether = new SomInt(somInt1.Value, somInt2.Value);
            Console.WriteLine($"SomInt1 {somInt1.Value} + SomInt2 {somInt2.Value} is result: {somIntsTogether.Value}");
        }

        public static void OpdrachtCalc3()
        {
            /* --- Opdracht Calc 3
                - Pas de class en het programma aan, zorg er voor dat 1 keer een getal gevraagd wordt 
                dat dan 4 keer wordt opgeteld (dus invoer van ‘2’ levert resultaat ‘8’)
                - Zorg dat het goed gaat als geen getal wordt ingevoerd
                - Zorg dat het ‘goed gaat’ als de integers opgeteld samen te groot zijn om nog in een integer te passen. 
                (bijvoorbeeld dat dan een negatief getal wordt teruggegeven als foutcode)
                - Grootste int getal is: 2147483647
            */

            Console.WriteLine("Enter a number that will be multiplied by 4");
            if(!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Please try again, enter a integer number.");
                number = 0;
                OpdrachtCalc3();
                return; // this is important otherwise it will continue after the condition
            }
            
            SomInt somInt = new SomInt(number); // Create the Object

            // Cannot go over the max value of 2147483647
            if(somInt.Value > int.MaxValue)
            {
                Console.WriteLine($"{somInt.Value} cannot be greater than the maximum int number {int.MaxValue}");
            }

            if(somInt.Value < 0)
            {
                Console.WriteLine("Negative number as result is not allowed.");
                return;
            }
            Console.WriteLine($"{number} x 4 is result: {somInt.Value}");
        }
    }
}