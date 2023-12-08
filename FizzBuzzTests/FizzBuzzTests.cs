using Moq;
using Range = System.Range;
using SolidFizzBuzz.Fizzbuzz;
using SolidFizzBuzz.Fizzbuzz.Rules;

namespace FizzBuzzTests
{
    public class FizzBuzzTests
    {
        private Mock<IResultHandler> _mockResultHandler;
        private List<string> _mockResults;

        private FizzbuzzServiceBase _fizzbuzz;

        public FizzBuzzTests()
        {
            // Arrange
            var rules = new List<IRule> { new FizzRule(), new BuzzRule() };

            _mockResultHandler = new Mock<IResultHandler>();
            _mockResults = new();
            _mockResultHandler.Setup(r => r.Handle(It.IsAny<string>()))
                .Callback<string>(result => _mockResults.Add(result));

            _fizzbuzz = new FizzbuzzService(_mockResultHandler.Object, rules.ToArray());
        }


        [Theory]
        [InlineData(1)]
        [InlineData(13)]
        public void TestIterationsAmount(int iterations)
        {
            // Act
            _fizzbuzz.Run(new Range(1, iterations + 1));

            // Assert
            _mockResultHandler.Verify(r => r.Handle(It.IsAny<string>()), Times.Exactly(iterations));
        }

        [Theory]
        [InlineData(27, 28, "Fizz")]
        [InlineData(250, 251, "Buzz")]
        [InlineData(1500, 1501, "FizzBuzz")]
        [InlineData(1, 16,
            "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz")]
        public void TestServiceWithRules(int rangeMin, int rangeMaxExclusive, string expectedResult)
        {
            // Act
            _fizzbuzz.Run(new Range(rangeMin, rangeMaxExclusive));

            // Assert
            Assert.True(string.Join(",", _mockResults) == expectedResult);
        }
    }
}