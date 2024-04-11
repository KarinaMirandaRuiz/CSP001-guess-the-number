using System;
using System.Text.RegularExpressions; 

namespace GuessTheNumber
{
    public class Program
    {
      
        public static void Main(/*String params*/)
        {
            Console.WriteLine("Hola! ¿Cómo quieres que te llame?");
            var namePlayer = Console.ReadLine();
            namePlayer = Regex.Replace(namePlayer, @"\s+", " ");
            while (namePlayer.Length == 0 || namePlayer == " ")
            {
                Console.WriteLine("No ingresó un nombre válido, intente de nuevo");
                namePlayer = Console.ReadLine();
            }

            Console.WriteLine($"Comenzamos el juego {namePlayer}!");

            Game game = new Game(namePlayer);
            game.GamePlayer();
        }
    }
}