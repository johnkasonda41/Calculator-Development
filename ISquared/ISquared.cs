using System;
using Squaring;

namespace ISquared
{
    public interface ISquared
    {
        public dynamic Square(dynamic a);
    }
    public class Squares : ISquared
    {
        public dynamic result;

        public dynamic Square(dynamic a)
        {
            result = Square(a);
            return result;
        }

    }
}
