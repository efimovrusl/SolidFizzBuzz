using SolidFizzBuzz.Fizzbuzz.Rules;

namespace SolidFizzBuzz.Fizzbuzz
{

    public abstract class FizzbuzzServiceBase
    {
        private IResultHandler _handler;
        private List<IRule> _rules;

        public FizzbuzzServiceBase(IResultHandler handler, params IRule[] rules)
        {
            _handler = handler;
            _rules = rules.ToList();
        }

        public abstract void Run(Range range);
    }

    public class FizzbuzzService : FizzbuzzServiceBase
    {
        public FizzbuzzService(IResultHandler handler, params IRule[] rules) : base(handler, rules)
        {
            throw new NotImplementedException();
        }

        public override void Run(Range range)
        {
            throw new NotImplementedException();
        }
    }
}
