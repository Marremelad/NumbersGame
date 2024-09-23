//Lab 3 - Gissa numret
//Mauricio Corte
//.NET24

namespace NumbersGame;

class Program
{
    static void Main(string[] args)
    {
        // Method to prompt the user to choose a difficulty level and return the corresponding value.
        int ChooseDifficulty()
        {
            int difficulty;
            while (true)
            {
                Console.WriteLine("Please enter a level between 1 and 3.");
                
                // Exit the loop if the input is valid.
                if (int.TryParse(Console.ReadLine(), out difficulty) && difficulty >= 1 && difficulty <= 3) break;
            }

            // Return the difficulty value based on the user's choice using a switch expression.
            return difficulty switch
            {
                1 => 10,
                2 => 5,
                3 => 1,
                // Handle unexpected values, though this should not be reached
                _ => throw new ArgumentOutOfRangeException() 
            };
        }
        
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
            // Compare the numbers, output if right or wrong.
            Console.WriteLine(userNumber == randomlyGeneratedNumber ? "Congratulations, you won!" :
                userNumber > randomlyGeneratedNumber ? "You guessed to high." :
                "You guessed to low.");
            
            return userNumber == randomlyGeneratedNumber;
        }
        
        // Method to start and manage the game.
        void PlayGame()
        {
            int randomlyGeneratedNumber = GetRandomNumber(); // Generate a new random number.
            int numberOfTries = ChooseDifficulty(); // Initialize number of tries.
            
            // Compare user input to random number and track number of times guessed.
            while (true)
            {
                Console.Write($"You have {numberOfTries} number of tries left. ");
                if (!CompareNumbers(GetNumber(), randomlyGeneratedNumber))
                {
                    numberOfTries--;
                    if (numberOfTries == 0)
                    {
                        Console.WriteLine("You lose...");
                        break;
                    }
                }
                else break;
            }
                
        }
        
        // Main game loop.
        do
        {
            Console.Clear(); // Clear the console for a fresh start.
            Console.WriteLine("Welcome to the Numbers Game! Can you guess the number? Good luck!");
            PlayGame(); // Start a new game.
            
            Console.WriteLine("Do you want to play again? (y/n)."); 
        
            // Check if the user wants to play again.   
        } while (Console.ReadLine()?.ToLower( ) == "y");
        
        // End of the game.
        Console.WriteLine("Thank you for playing!");
    }  
}