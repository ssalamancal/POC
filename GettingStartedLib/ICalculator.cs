﻿using System.ServiceModel;

namespace GettingStartedLib
{
  [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
  public interface ICalculator
  {
    [OperationContract]
    double Add(double n1, double n2);
    [OperationContract]
    double Subtract(double n1, double n2);
    [OperationContract]
    double Multiply(double n1, double n2);
    [OperationContract]
    double Divide(double n1, double n2);
  }
}