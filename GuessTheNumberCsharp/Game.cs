// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

public class Game
{
    //Atributos
    private Player _humanPlayer;
    private Player _AIPlayer;

    private List<int> minGuesses = new List<int>{0};
    private List<int> maxGuesses = new List<int>{100};

    private Random random = new Random();
    private int secretNumber;

    // Métodos
    public Game(string name)
    {
        secretNumber = RandomNumberGenerator(0,100);
        //secretNumber = 10;
        this._humanPlayer = new HumanPlayer(name);
        this._AIPlayer = new AIPlayer("AI Player");
    }
    private int RandomNumberGenerator(int min, int max)
    {
        return random.Next (min,max + 1);
    }

    private bool CheckGuess(int guess, int secretNumber)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;

        if (secretNumber < guess)
        {
            maxGuesses.Add(guess);
            Console.WriteLine("Tu número es mayor que el número oculto");
            Console.WriteLine("----------------------------------------");
            return false;
        }
        else if (secretNumber > guess)
        {
            minGuesses.Add(guess);
            Console.WriteLine("Tu número es menor que el número oculto");
            Console.WriteLine("----------------------------------------");
            return false;
        }
        
        return true;
    }

    public void GamePlayer()
    {

            //Console.Clear();

        string turnName = _humanPlayer.name;
        int guess = _humanPlayer.MakeGuess();
        
        while (!CheckGuess(guess, secretNumber))
        {
            if (turnName == _humanPlayer.name)
            {
                turnName = "AI Player";
                guess = _AIPlayer.MakeGuess(minGuesses.Max()+1,maxGuesses.Min());
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(guess);
                // Console.WriteLine("Turno AI");
            }
            else
            {
                turnName = _humanPlayer.name;
                guess = _humanPlayer.MakeGuess();
                // Console.WriteLine("Turno humano");
            }
        }
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n   ¡¡Acertaste {turnName}!!, el número secreto es {secretNumber}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\nIntentos de {_humanPlayer.name}: {string.Join(", ", _humanPlayer.Guesses)}");
            Console.WriteLine($"Intentos de AI player: {string.Join(", ", _AIPlayer.Guesses)}\n");

            if (turnName == "AI Player")
            {

                Console.WriteLine("  ⊂_ヽ");
                Console.WriteLine("    ＼＼");
                Console.WriteLine("     ＼( ͡ ° ͜ʖ ͡° ) EL FUTURO ES AHORA VIEJO");
                Console.WriteLine("       >  ⌒ヽ");
                Console.WriteLine("      /    へ＼");
                Console.WriteLine("     /    / ＼＼");
                Console.WriteLine("     ﾚ  ノ     ヽ_つ");
                Console.WriteLine("    /  /");
                Console.WriteLine("   /  /|");
                Console.WriteLine("  (  (＼");
                Console.WriteLine("  |  |、＼");
                Console.WriteLine("  | 丿 ＼ ⌒)");
                Console.WriteLine("  | |    ) /");
                Console.WriteLine(" ノ )    Lﾉ");
                Console.WriteLine("(_／");
            }
            else{
                Console.WriteLine("   ___________________");
                Console.WriteLine("  |     AI player     |");
                Console.WriteLine("  |-------------------|");
                Console.WriteLine("  |                   |");
                Console.WriteLine("  |   ∧＿∧  ...perdí? |");
                Console.WriteLine("  |（； ･д･）         |");
            }
    }
}
