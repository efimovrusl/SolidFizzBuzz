using SolidFizzBuzz.Fizzbuzz.Rules;

namespace FizzBuzzTests
{
    public class RulesTests
    {
        [Theory]
        [InlineData(1, false)]
        [InlineData(5, false)]
        [InlineData(3, true, "Fizz")]
        [InlineData(399, true, "Fizz")]
        public void TestFizz(int number, bool shouldBeAbleToProcess, string expectedResult = "")
        {
            IRule fizzRule = new FizzRule();

            var canProcess = fizzRule.TryProcess(number, out string result);

            Assert.True(canProcess == shouldBeAbleToProcess && result == expectedResult);
        }

        [Theory]
        [InlineData(1, false)]
        [InlineData(3, false)]
        [InlineData(5, true, "Buzz")]
        [InlineData(625, true, "Buzz")]
        public void TestBuzz(int number, bool shouldBeAbleToProcess, string expectedResult = "")
        {
            IRule fizzRule = new BuzzRule();

            var canProcess = fizzRule.TryProcess(number, out string result);

            Assert.True(canProcess == shouldBeAbleToProcess && result == expectedResult);
        }
    }


}
