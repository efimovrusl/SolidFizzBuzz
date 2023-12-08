namespace SolidFizzBuzz.Fizzbuzz.Rules
{
    public class BuzzRule : IRule
    {
        public bool TryProcess(int number, out string result)
        {
            var canProcess = number % 5 == 0;

            result = canProcess ? "Buzz" : string.Empty;

            return canProcess;
        }
    }
}
