using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WcfMathServiceLibrary
{
    [ServiceContract]
    public interface IMath
    {
        [OperationContract]
        double Add(double i, double j);
        [OperationContract]
        double Sub(double i, double j);
        [OperationContract]
        Complex AddComplexNo(Complex i, Complex j);
        [OperationContract]
        Complex SubComplexNo(Complex i, Complex j);
    }

    // Use a data contract
    [DataContract] //using System.Runtime.Serialization
    public class Complex
    {
        private int real;
        private int imaginary;

        [DataMember]
        public int Real { get; set; }

        [DataMember]
        public int Imaginary { get; set; }
    }
}
