namespace NumbersGame;

class Program
{
    static void Main(string[] args)
    {
        int GetNumber()
        {
            int userNumber;
            bool isNumber;
            do
            {
                Console.WriteLine("Please enter an integer between 1 and 20.");
                isNumber = int.TryParse(Console.ReadLine(), out userNumber);
            } while (!isNumber || userNumber > 20 || userNumber < 0);

            return userNumber;
        }
        
        int GetRandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 21);
            return randomNumber; 
        }

        bool CompareNumbers(int userNumber, int randomlyGeneratedNumber)
        {
            bool isWinner;

            if (userNumber != randomlyGeneratedNumber)
            {
                isWinner = false;
                if (userNumber < randomlyGeneratedNumber)
                {
                    Console.WriteLine("You guessed to low");
                }
                else if (userNumber > randomlyGeneratedNumber)
                {
                    Console.WriteLine("You guessed to high");
                }
            }
            else
            {
                isWinner = true;
                Console.WriteLine("You got it right");
            }

            return isWinner;
        }

        void InitiateGame()
        {
            bool isWinner;
            int numberOfTries = 0;
            int randomlyGeneratedNumber = GetRandomNumber();
        
            do
            {
                int userNumber = GetNumber();
                
                isWinner = CompareNumbers(userNumber, randomlyGeneratedNumber);
                numberOfTries += 1;
                
                if (numberOfTries == 5)
                {
                    Console.WriteLine("You lose!");
                    break;
                }
                
                Console.WriteLine($"you have {5 - numberOfTries} tries!");
                
            } while (!isWinner); 
        }
        
        bool play = false;
        Console.WriteLine("Welcome to the Numbers Game!");
        
        do
        {
            InitiateGame();
            Console.WriteLine("Do you want to play again? (y/n)");
            string? userInput = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(userInput) && userInput.ToLower() == "y")
            {
                play = true;
            }

        } while (play);
    }
}