using System;
using Helpers;

namespace Squareroot
{
    public class Squareroot
    {
        public static double Squarerooting(int a)
        {
            return Rounding.RoundTwoDecimalPlaces(Math.Sqrt(a));
        }
        public static double Squarerooting(double a)
        {
            return Rounding.RoundTwoDecimalPlaces(Math.Sqrt(a));
        }
    }
}