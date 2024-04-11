// See https://aka.ms/new-console-template for more information
public class Game
{
    //Atributos
    private Random random = new Random();
    public int secretNumber;
    private Player player;
    // Métodos
    public Game(string name)
    {
        //secretNumber = random.Next (0,100 + 1);
        secretNumber = 10;
        this.player = new Player(name);
    }

    public void GamePlayer()
    {
        int guess = player.MakeGuess();
        do
        {
        if (secretNumber < guess)
            {
                Console.WriteLine("Tu número es mayor");
                Console.WriteLine("-----------------------");
                guess = player.MakeGuess();
            }
            else if (secretNumber > guess)
            {
                Console.WriteLine("Tu número es menor");
                Console.WriteLine("-----------------------");
                guess = player.MakeGuess();
            }
        }
        while (secretNumber != guess);
        
        if(player.lastGuess == secretNumber)
            {
                Console.WriteLine($"Acertaste {player.name}!!, el número secreto es {secretNumber}");
            } 
    }
}



