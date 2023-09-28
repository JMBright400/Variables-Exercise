namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "John Bright";
            int yearsOfService = 12;
            char numberOfBases = '7';
            bool yearsRemainingOfTotal = false;
            double yearsRemainingOfEnlistment = 3;
            decimal yearsRemainingUntilCompletion = 8;
            
            Console.WriteLine($"My name is {myName}, I have served in the U.S. Air Force for {yearsOfService} years. Within my {yearsOfService} years of service I have been stationed at {numberOfBases} different military bases. I currently have {yearsRemainingOfEnlistment} years left of my current enlistment and {yearsRemainingUntilCompletion} years remaining until completion of 20 total years.");


        }
    }
}
