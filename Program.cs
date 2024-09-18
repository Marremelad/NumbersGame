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
            int randomlyGeneratedNumber = GetRandomNumber();
        
            do
            {
                int userNumber = GetNumber();
                isWinner = CompareNumbers(userNumber, randomlyGeneratedNumber);
            
            } while (!isWinner); 
        }
        
        Console.WriteLine("Welcome to the Numbers Game!");
    }
}