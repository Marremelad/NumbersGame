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
                Console.Clear();
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
            return userNumber == randomlyGeneratedNumber ? true : false;
        }
        
        
    }
}