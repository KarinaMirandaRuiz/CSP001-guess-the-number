using System;
using System.Text.RegularExpressions; 

namespace GuessTheNumber
{
    public class Program
    {
        public static void Main()
        {
  
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("¡Hey! ¿Cómo prefieres que te llame?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string? namePlayer = Console.ReadLine();
            if (!String.IsNullOrEmpty(namePlayer))
            {
                namePlayer = Regex.Replace(namePlayer, @"\s+", " ");
            }
            while (String.IsNullOrEmpty(namePlayer) || namePlayer.Length == 0 || namePlayer == " ")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("ups! No ingresaste un nombre válido, intentalo de nuevo");

                Console.ForegroundColor = ConsoleColor.Cyan;
                namePlayer = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\n¡Listo, {namePlayer}!");
            Console.WriteLine("Recuerda: Trata de adivinar el número oculto, del 0 al 100, ");
            Console.WriteLine("antes de que la computadora, tu oponente AI, lo haga primero.");
            Console.WriteLine("\n\n  ¡Comenzamos!");
            Console.WriteLine("----------------------------------------");

            Game game = new Game(namePlayer);
            game.GamePlayer();
            Console.ResetColor();
        }
    }
}