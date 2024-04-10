// See https://aka.ms/new-console-template for more information

Random random = new Random();

//int secretNumber = random.Next (0,100 + 1);
int secretNumber = 10;

Console.WriteLine("Inserte un número:");

var guess = Console.ReadLine();

double numericGuess = Convert.ToDouble(guess);

do
{
if (secretNumber < numericGuess)
    {
        Console.WriteLine("Tu número es mayor");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Inserte otro número:");
        guess = Console.ReadLine();
        numericGuess = Convert.ToDouble(guess);
    }
    else if (secretNumber > numericGuess)
    {
        Console.WriteLine("Tu número es menor");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Inserte otro número:");
        guess = Console.ReadLine();
        numericGuess = Convert.ToDouble(guess);    
    }
}
while (secretNumber != numericGuess);

if(secretNumber == numericGuess)
{
    Console.WriteLine($"Acertaste!!, el número secreto es {secretNumber}");
} 

