using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string choice = "";
            int n1, n2;
            string n3, n4;
            int sum;
            string reverse;
            string htmlTag, htmlTag2;
            string s1;
            string choice2 = "";


            double no1, no2, no3, no4, no5;
            double[] no6;

            while (!choice.Equals("6"))
            {
                Console.WriteLine("\t\t\tWCF Assignment 1");
                Console.Write("1. Finding Prime Numbers\n");
                Console.Write("2. Sum Of Digits\n");
                Console.Write("3. Reverse A String\n");
                Console.Write("4.Print HTML Tags\n");
                Console.Write("5. Sort 5 Numbers\n");
                Console.Write("6. Exit\n");
                Console.Write("\t\tEnter your choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter A Number: ");
                        n1 = Int32.Parse(Console.ReadLine());
                        s1 = client.PrimeNumbers(n1);
                        Console.Write("This number you have entered: " + s1 + "\n");
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.Write("Enter A Number With 2 Digits: ");
                        sum = Int32.Parse(Console.ReadLine());
                        n2 = client.SumOfDigits(sum);
                        Console.Write("So the SUM of this digit is: " + n2 + "\n");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.Write("Enter A String Value: ");
                        reverse = Console.ReadLine();
                        n3 = client.ReverseAString(reverse);
                        Console.Write("So the Reverse of your input is : " + n3 + "\n");
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.Write("Enter A html tag: ");
                        htmlTag = Console.ReadLine();
                        Console.Write("Enter Data: ");
                        htmlTag2 = Console.ReadLine();
                        n4 = client.HtmlTags(htmlTag, htmlTag2);
                        Console.Write(n4 + "\n");
                        Console.ReadLine();
                        break;

                    case "5":
                        while (!choice2.Equals("3"))
                        {
                            Console.Write("1. Ascending ");
                            Console.Write("2. Descending ");
                            Console.Write("3. Exit ");
                            choice2 = Console.ReadLine();   
                            if (choice2 == "1")
                            {
                                Console.Write("Enter number 1: ");
                                no1 = double.Parse(Console.ReadLine());
                                Console.Write("Enter number 2: ");
                                no2 = double.Parse(Console.ReadLine());
                                Console.Write("Enter number 3: ");
                                no3 = double.Parse(Console.ReadLine());
                                Console.Write("Enter number 4: ");
                                no4 = double.Parse(Console.ReadLine());
                                Console.Write("Enter number 5: ");
                                no5 = double.Parse(Console.ReadLine());
                                no6 = client.SortNumbers(no1, no2, no3, no4, no5);
                                no6.ToList().ForEach(x => Console.Write(x + "\n"));
                                Console.ReadLine();
                            }
                            if (choice2 == "2")
                            {
                                Console.Write("Enter number 1: ");
                                no1 = double.Parse(Console.ReadLine());
                                Console.Write("Enter number 2: ");
                                no2 = double.Parse(Console.ReadLine());
                                Console.Write("Enter number 3: ");
                                no3 = double.Parse(Console.ReadLine());
                                Console.Write("Enter number 4: ");
                                no4 = double.Parse(Console.ReadLine());
                                Console.Write("Enter number 5: ");
                                no5 = double.Parse(Console.ReadLine());
                                no6 = client.SortDescNumbers(no1, no2, no3, no4, no5);
                                no6.ToList().ForEach(x => Console.Write(x + "\n"));
                                Console.ReadLine();
                            }

                        }
                        break;
                }
            }
        }
    }
}
