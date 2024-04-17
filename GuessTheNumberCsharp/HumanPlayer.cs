public class HumanPlayer : Player
{
    public HumanPlayer(string name): base(name)
    {}

    public override int MakeGuess(int min = 0, int max = 0)
    {
        double numericGuess;
        int intGuess;

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Turno de {name}: \nInserte un número entero.");

        Console.ForegroundColor = ConsoleColor.Cyan;
        string? guess = Console.ReadLine();

        while(
            !int.TryParse(guess, out intGuess) 
            || int.TryParse(guess, out intGuess) != double.TryParse(guess, out numericGuess)
            )  // mientras no pueda convertirlo a double o no sea entero, seguirá haciendo peticiones
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (int.TryParse(guess, out intGuess) != double.TryParse(guess, out numericGuess))
            {
                Console.WriteLine("No es un número entero, intente de nuevo");
            } 
            else 
            {
                Console.WriteLine("No se ha insertado un número válido, intente de nuevo");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            guess = Console.ReadLine();
        }

        intGuess = Convert.ToInt32(guess);

        this.PushGuess(intGuess);
        
        return intGuess;
    }
}