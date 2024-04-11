// See https://aka.ms/new-console-template for more information
public class Game
{
    //Atributos
    private Random random = new Random();
    private int secretNumber;
    private Player player;
    // Métodos
    public Game(string name)
    {
        //secretNumber = RandomNumberGenerator(0,100);
        secretNumber = 10;
        this.player = new Player(name);
    }
    private int RandomNumberGenerator(int min, int max)
    {
        return random.Next (min,max + 1);
    }

    private bool CheckGuess(int guess, int secretNumber)
    {
        if (secretNumber < guess)
        {
            Console.WriteLine("Tu número es mayor");
            Console.WriteLine("-----------------------");
            return false;
        }
        else if (secretNumber > guess)
        {
            Console.WriteLine("Tu número es menor");
            Console.WriteLine("-----------------------");
            return false;
        }
        
        return true;
    }

    public void GamePlayer()
    {
        int guess = player.MakeGuess();
        do
        {
            guess = player.MakeGuess();
        }
        while (!CheckGuess(guess, secretNumber));
        
        if(CheckGuess(player.GetLastGuess(), secretNumber))
            {
                Console.WriteLine($"Acertaste {player.name}!!, el número secreto es {secretNumber}");
            } 
    }
}



