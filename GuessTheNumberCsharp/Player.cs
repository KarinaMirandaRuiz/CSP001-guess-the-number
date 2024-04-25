public abstract class Player
{
    //Atributos
    public string? name;
    public int lastGuess;
    public List<int?> Guesses = new List<int?>{};

    // Métodos
    protected Player(string name)
    {
        this.name = name;
        lastGuess = 0;
    }

    public void PushGuess(int guess)
    {
        this.Guesses.Add(guess);
        lastGuess = guess;
    }

    public int GetLastGuess()
    {
        return lastGuess;
    }

    public int GetTries(){
        return Guesses.Count;
    }

    public abstract int MakeGuess(int min = 0, int max = 100);

}