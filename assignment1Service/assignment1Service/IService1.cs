using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace assignment1Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string PrimeNumbers(int number);
        [OperationContract]
        int SumOfDigits(int sumOfDigits);
        [OperationContract]
        string ReverseAString(string s1);
        [OperationContract]
        string HtmlTags(string s1, string s2);
        [OperationContract]
        double[] SortNumbers(double n1, double n2, double n3, double n4, double n5);
        [OperationContract]
        double[] SortDescNumbers(double n1, double n2, double n3, double n4, double n5);

    }


   
    
}
