using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Kalkylator");

        char operation;
        // Loopar tills en giltig operation anges
        while (true)
        {
            Console.WriteLine("Välj en operation (+, -, *, /, r för kvadratrot):");
            operation = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Går till nästa rad

            // Kontrollera om operationen är giltig
            if (operation == '+' || operation == '-' || operation == '*' || operation == '/' || operation == 'r')
            {
                break; // Bryter loopen om operationen är giltig
            }
            else
            {
                Console.WriteLine("Fel: Ogiltig operation. Försök igen."); // Meddelande vid ogiltig inmatning
            }
        }

        double num1, num2;
        // Om operationen är kvadratrot, behöver vi bara ett tal
        if (operation == 'r')
        {
            Console.WriteLine("\nAnge talet för att ta kvadratroten:");
            num1 = Convert.ToDouble(Console.ReadLine());
            double result = Math.Sqrt(num1); // Beräkna kvadratroten
            Console.WriteLine($"Resultat: {result}");
        }
        else
        {
            // Ber användaren ange det första talet
            Console.WriteLine("\nAnge första talet:");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Ber användaren ange det andra talet
            Console.WriteLine("Ange andra talet:");
            num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            // Utför beräkningen baserat på den valda operationen
            switch (operation)
            {
                case '+':
                    result = num1 + num2; // Addition
                    break;
                case '-':
                    result = num1 - num2; // Subtraktion
                    break;
                case '*':
                    result = num1 * num2; // Multiplikation
                    break;
                case '/':
                    result = num2 != 0 ? num1 / num2 : double.NaN; // Division med kontroll för noll
                    break;
                default:
                    Console.WriteLine("Fel: Ogiltig operation."); // Ska aldrig nås
                    return;
            }

            // Skriver ut resultatet
            Console.WriteLine($"Resultat: {result}");
        }

        Console.ReadKey(); // Väntar på användarens tangenttryckning innan programmet avslutas
    }
}
