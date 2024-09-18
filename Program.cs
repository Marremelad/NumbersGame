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

        string CompareNumbers(int userNumber, int randomlyGeneratedNumber) // Change to bool method.
        {
            string? result;

            if (userNumber != randomlyGeneratedNumber)
            {
                result = userNumber < randomlyGeneratedNumber ? "You guessed to low" : "You guessed to high";
            }
            else
            {
                result = "You guessed correctly";
            }

            return result; // return bool and print result statements instead.

        } 
    }
}