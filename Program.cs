namespace ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        Duck[] ducks = new Duck[8];
        Console.WriteLine($"Please enter START to start the game: ");
        string input = Console.ReadLine();
        Random random = new Random();
        int shotedDucks = 0;

        if (input.ToLower() == "start")
        {
            for (int i = 0; i < 8; i++)
            {
                int Id = random.Next(1, 6);
                ducks[i] = new Duck(Id);
            }

            for (int j = 20; j > 0; j--)
            {
                Console.WriteLine($"You have {j} bullets");
                foreach (Duck duck in ducks)
                {
                    duck.Voice();
                    Console.WriteLine("To shot Duck enter number from 1 to 5 and try fo chatch her!\r\n enter number:");
                    int inputNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bang!");
                    if (inputNumber == duck.Id)
                    {
                        duck.Die();
                        shotedDucks++;
                    }
                    else duck.Fly();
                }
            }
            if (shotedDucks < 5)
            {
                Console.WriteLine($"Game Over, your shoted {shotedDucks} ducks!");
            }
            else
            {
                Console.WriteLine($"Cograts! You shoted {shotedDucks} ducks ");
                }
        }
        else
            Console.WriteLine("Invalid input");
    }
}
