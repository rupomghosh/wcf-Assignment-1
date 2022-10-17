using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Windows.Input;

namespace assignment1Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string PrimeNumbers(int number)
        {
            int div = 0;
            string prime = "is a prime number";
            string notPrime = "is not a prime number";

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    div++;
                }
            }
            if (div == 2)
            {
                return prime;
            }
            else
            {
                return notPrime;
            }

        }

        public int SumOfDigits(int p)
        {
            int q;
            int sum = 0;
            while (p > 0)
            {
                q = p % 10;
                sum = sum + q;
                p = p / 10;
            }
            return sum;
        }

        public string ReverseAString(string s1)
        {
            char[] myArr = s1.ToCharArray();

            string stringReverse = String.Empty;

            int size;
            int i;
            size = myArr.Length - 1;
            i = size;
            while (i > -1)
            {
                stringReverse = stringReverse + myArr[i];
                i--;
            }

            return stringReverse;
        }

        public string HtmlTags(string s1, string s2)
        {
            string s3 = "<" + s1 + "/>" + s2 + "<" + s1 + "/>";
            return s3;
        }

        public double[] SortNumbers(double n1, double n2, double n3, double n4, double n5)
        {
            var values = new double[] { n1, n2, n3, n4, n5 };
            var sortedValues = values.OrderBy(v => v).ToList();
            var v1 = sortedValues.ToArray(); 

            return v1;
        }

        public double[] SortDescNumbers(double n1, double n2, double n3, double n4, double n5)
        {
            var values = new double[] { n1, n2, n3, n4, n5 };
            var sortedValues = values.OrderByDescending(v => v).ToList();
            var v1 = sortedValues.ToArray();

            return v1;
        }
    }
}
