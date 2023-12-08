namespace SolidFizzBuzz.Fizzbuzz
{
    public interface IResultHandler
    {
        public void Handle(string str);
    }

    public class ResultHandler : IResultHandler
    {
        public void Handle(string str)
        {
            throw new NotImplementedException();
        }
    }
}
