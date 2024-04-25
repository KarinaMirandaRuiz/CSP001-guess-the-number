public class AIPlayer : Player
{
    private Random random = new Random();
    public AIPlayer(string name): base(name)
    {}

    public override int MakeGuess(int min, int max)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Turno AI: \nInserte un número entero.");
        int intGuess = random.Next(min, max);
        this.PushGuess(intGuess);
        return intGuess;
    }
}