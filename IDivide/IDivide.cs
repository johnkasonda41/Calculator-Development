using System;
using Division;

namespace IDivide
{
    public interface IDivide
    {
        public dynamic Divide(dynamic a, dynamic b);
    }
    public class Div : IDivide
    {
        public dynamic result;
        public dynamic Divide(dynamic a, dynamic b)
        {
            result = Divide(a, b);
            return result;
        }
    }
}
