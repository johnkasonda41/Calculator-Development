using System;
using Addition;

namespace IAdd
{
    public interface IAdd
    {
        public dynamic Add(dynamic a, dynamic b);
    }
    public class Ad : IAdd
    {
        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = Addition.Addition.Sum(a, b);
            return result;
        }

        public dynamic Add(dynamic a)
        {
            result = Addition.Addition.Sum(a);
            return result;
        }
    }
}
