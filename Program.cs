namespace NumbersGame;

class Program
{
    static void Main(string[] args)
    {
        // Method to get a valid user input.
        int GetNumber()
        {
            int userNumber;
            bool isNumber;
            do
            {
                Console.WriteLine("Please enter an integer between 1 and 20.\n");
                // Try to parse the user input as an integer.
                isNumber = int.TryParse(Console.ReadLine(), out userNumber);
            } while (!isNumber || userNumber < 1 || userNumber > 20);

            return userNumber;
        }
        
        // Method to generate a random number between 1 and 20.
        int GetRandomNumber() => new Random().Next(1, 21); 

        // Method to compare user's guess with the randomly generated number.
        bool CompareNumbers(int userNumber, int randomlyGeneratedNumber)
        {
            // Print appropriate message based on comparison.
            Console.WriteLine(userNumber == randomlyGeneratedNumber 
                ? "Congratulations, You won!" 
                : userNumber < randomlyGeneratedNumber 
                    ? "You guessed to low!" 
                    : "You guessed to high!");
            
            // Return whether the user guessed correctly.
            return userNumber == randomlyGeneratedNumber;

        }
       
        // Method to check if the user is out of tries or has won.
        bool OutOfTries(bool isWinner, int numberOfTries)
        {
            if (numberOfTries >= 5)
            {
                Console.WriteLine("\nYou lose!");
                return true; // Game over if the user runs out of tries.
            }
            return isWinner; // Return whether the user has won.
        }

        // Method to start and manage the game.
        void InitiateGame()
        {
            int randomlyGeneratedNumber = GetRandomNumber(); // Generate a new random number.
            int numberOfTries = 0; // Initialize number of tries.
            
            do
            {
                Console.WriteLine($"Number of tries left: {5 - numberOfTries}.");
                numberOfTries++; // Increment the number of tries.

                // Continue the game until the user wins or runs out of tries.
            } while (!OutOfTries(CompareNumbers(GetNumber(), randomlyGeneratedNumber), numberOfTries)); 
        }

        // Main game loop.
        do
        {
            Console.Clear(); // Clear the console for a fresh start.
            Console.WriteLine("Welcome to the Numbers Game!");
            InitiateGame(); // Start a new game.
            
            Console.WriteLine("\nDo you want to play again? (y/n)."); 
        
            // Check if the user wants to play again.   
        } while (Console.ReadLine()?.ToLower( ) == "y");
        
        // End of the game.
        Console.WriteLine("Thanks you for playing!");
    }
}