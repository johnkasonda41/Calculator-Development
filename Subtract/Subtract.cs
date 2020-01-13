using System;
using Subtraction;

namespace Subtract
{
    public interface ISubtract
    {
        public dynamic Subtract(dynamic a, dynamic b);
    }
    public class Subtracts : ISubtract
    {
        public dynamic result;
        public dynamic Subtract(dynamic a, dynamic b) 
        {
            result = Subtraction.Subtraction.Difference(a, b);
            return result;

        }

       

    }
}
