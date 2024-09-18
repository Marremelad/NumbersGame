namespace NumbersGame;

class Program
{
    static void Main(string[] args)
    { 
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