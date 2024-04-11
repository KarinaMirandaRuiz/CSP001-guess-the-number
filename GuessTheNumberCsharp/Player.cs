public class Player
{
    //Atributos
    public string name;
    public int lastGuess;
    private List<int> Guesses = new List<int>{};

    // Métodos
    public Player(string name)
    {
        this.name = name;
        lastGuess = 0;
    }

    private void PushGuess(int guess)
    {
        Guesses.Add(guess);
        lastGuess = guess;
    }

    public int GetTries(){
        return Guesses.Count;
    }

    public int MakeGuess()
    {
        
        double numericGuess;
        int intGuess;
        Console.WriteLine("Inserte un número entero:");
        var guess = Console.ReadLine();
        while(
            !double.TryParse(guess, out numericGuess) 
            || int.TryParse(guess, out intGuess) != double.TryParse(guess, out numericGuess)
            )  // mientras no pueda convertirlo a double o no sea entero, seguirá haciendo peticiones
        {
            if (int.TryParse(guess, out intGuess) != double.TryParse(guess, out numericGuess))
            {
                Console.WriteLine("No es un número entero, intente de nuevo");
            } 
            else 
            {
                Console.WriteLine("No se ha insertado un número válido, intente de nuevo");
            }
            guess = Console.ReadLine();
            intGuess = Convert.ToInt32(guess);
        }

        PushGuess(intGuess);
        
        return intGuess;
        
    }
}