using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalculatorWCFExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        double add(double num1,double num2);
        [OperationContract]
        double sub(double num1, double num2);
        [OperationContract]
        double multiply(double num1, double num2);
        [OperationContract]
        double divide(double num1, double num2);





    }


}


    