using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkel_miniräknare

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enkel kalkylator");
        Console.WriteLine("Välj en operator (+, -, /, *, %)");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine("Ange första talet: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ange andra talet: ");
        double num2 = Convert.ToDouble(Console.ReadLine());



        double result = 0;
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num2 - num1;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Fel: Division med noll är inte tillåten.");
                    return;
                }
                result = num1 / num2;
                break;
            case '%':
                result = num1 % num2;
                break;

            default:
                Console.WriteLine("Ogiltig operation");
                return;

        }

        Console.WriteLine($"Resultat: {result}");
        Console.ReadKey();
    }
}

}
