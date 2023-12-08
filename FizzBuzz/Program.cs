using SolidFizzBuzz.Fizzbuzz;
using SolidFizzBuzz.Fizzbuzz.Rules;

// Usage example
List<IRule> rules = new() { new FizzRule(), new BuzzRule() };
FizzbuzzService fizzbuzz = new (new ResultHandler(), rules.ToArray());

fizzbuzz.Run(new Range(1, 16));

// Wait
Console.ReadKey();