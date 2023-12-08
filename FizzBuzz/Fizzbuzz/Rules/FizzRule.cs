namespace SolidFizzBuzz.Fizzbuzz.Rules
{
    public class FizzRule : IRule
    {
        public bool TryProcess(int number, out string result)
        {
            var canProcess = number % 3 == 0;

            result = canProcess ? "Fizz" : string.Empty;

            return canProcess;
        }
    }
}
