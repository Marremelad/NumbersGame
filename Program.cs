namespace NumbersGame;

class Program
{
    static void Main(string[] args)
    {
        
        bool play;
        
        int GetNumber()
        {
            int userNumber;
            bool isNumber;
            do
            {
                Console.WriteLine("Please enter an integer between 1 and 20.\n");
                isNumber = int.TryParse(Console.ReadLine(), out userNumber);
            } while (!isNumber || userNumber < 1 || userNumber > 20);

            return userNumber;
        }

        int GetRandomNumber() => new Random().Next(1, 21);

        bool CompareNumbers(int userNumber, int randomlyGeneratedNumber)
        {
            Console.WriteLine(userNumber == randomlyGeneratedNumber 
                ? "Congratulations, You won!" 
                : userNumber < randomlyGeneratedNumber 
                    ? "You guessed to low!" 
                    : "You guessed to high!");
            
            return userNumber == randomlyGeneratedNumber;

        }
       
        bool OutOfTries(bool isWinner, int numberOfTries)
        {
            if (numberOfTries >= 5)
            {
                Console.WriteLine("\nYou lose!");
                return true;
            }
            return isWinner;
        }

        void InitiateGame()
        {
            int randomlyGeneratedNumber = GetRandomNumber();
            int numberOfTries = 0;
            Console.WriteLine(randomlyGeneratedNumber);
            
            do
            {
                Console.WriteLine($"Number of tries left: {5 - numberOfTries}.");
                numberOfTries++;

            } while (!OutOfTries(CompareNumbers(GetNumber(), randomlyGeneratedNumber), numberOfTries)); 
        }

        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Numbers Game!");
            InitiateGame();
            
            Console.WriteLine("\nDo you want to play again? (y/n).");
            play = Console.ReadLine()?.ToLower() == "y";

        } while (play);
    }
}