using SolidFizzBuzz.Fizzbuzz.Rules;
using System.Data;

namespace SolidFizzBuzz.Fizzbuzz
{

    public abstract class FizzbuzzServiceBase
    {
        protected IResultHandler _resultHandler;
        protected List<IRule> _rules;

        public FizzbuzzServiceBase(IResultHandler resultHandler, params IRule[] rules)
        {
            _resultHandler = resultHandler;
            _rules = rules.ToList();
        }

        public abstract void Run(Range range);
    }

    public class FizzbuzzService : FizzbuzzServiceBase
    {
        public FizzbuzzService(IResultHandler resultHandler, params IRule[] rules) : base(resultHandler, rules) { }

        public override void Run(Range range)
        {
            for (int i = range.Start.Value; i < range.End.Value; i++)
            {
                string output = "";
                foreach (var rule in _rules)
                {
                    var canHandle = rule.TryProcess(i, out string result);
                    if (canHandle)
                    {
                        output += result;
                    }
                }
                if (string.IsNullOrEmpty(output))
                {
                    output = $"{i}";
                }
                _resultHandler.Handle(output);
            }
        }
    }
}
