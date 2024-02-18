/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWCFExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
         double IService1.add(double num1, double num2)
        {
            return num1 + num2;
        }

         double IService1.divide(double num1, double num2)
        {
            return num1 / num2;
        }

        double IService1.multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        
        double IService1.sub(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalculatorWCFExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
         double IService1.add(double num1, double num2)
        {
            return num1 + num2;
        }

         double IService1.divide(double num1, double num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Cannot divide by zero");

            return num1 / num2;
        }

        double IService1.multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        double IService1. sub(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
