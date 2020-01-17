using System;
using SubtractInterface;

namespace SubtractInterface
{
    public interface ISubtract
    {
        public dynamic Difference(dynamic a, dynamic b);
    }
    public class Sub : ISubtract
    {
        public dynamic result;
        public dynamic Difference(dynamic a, dynamic b)
        {
            result = Subtraction.Subtraction.Difference(a, b);
            return result;
        }
    }
}
