using System;

namespace amigocebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("╔═════════════════════════════════════════╗");
            Console.WriteLine("║ M E U    A MI G O    C E B O L I N H A  ║");
            Console.WriteLine("╚═════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Digite uma frase para seu amiguinho: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string cebolinha = Console.ReadLine();
            string textoDigitado = cebolinha.Replace("r","l").Replace("rr","l");
            textoDigitado = textoDigitado.Replace("R","L").Replace("RR","L");
            Console.WriteLine(textoDigitado);
            Console.ResetColor();
           

            
        }
    }
}
