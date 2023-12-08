namespace SolidFizzBuzz.Fizzbuzz.Rules
{
    public interface IRule
    {
        public bool TryProcess(int number, out string result);
    }
}
