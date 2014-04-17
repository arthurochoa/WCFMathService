using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfMathServiceLibrary
{
    class MathService : IMath
    {
        public double Add(double i, double j)
        {
            return (i + j);
        }

        public double Sub(double i, double j)
        {
            return (i - j);
        }

        public Complex AddComplexNo(Complex i, Complex j)
        {
            Complex result = new Complex();
            result.Real = i.Real + j.Real;
            result.Imaginary = i.Imaginary + j.Imaginary;
            return result;
        }

        public Complex SubComplexNo(Complex i, Complex j)
        {
            Complex result = new Complex();
            result.Real = i.Real - j.Real;
            result.Imaginary = i.Imaginary - j.Imaginary;
            return result;
        }
    }
}
