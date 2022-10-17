﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace assignmentConsole.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrimeNumbers", ReplyAction="http://tempuri.org/IService1/PrimeNumbersResponse")]
        string PrimeNumbers(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrimeNumbers", ReplyAction="http://tempuri.org/IService1/PrimeNumbersResponse")]
        System.Threading.Tasks.Task<string> PrimeNumbersAsync(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SumOfDigits", ReplyAction="http://tempuri.org/IService1/SumOfDigitsResponse")]
        int SumOfDigits([System.ServiceModel.MessageParameterAttribute(Name="sumOfDigits")] int sumOfDigits1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SumOfDigits", ReplyAction="http://tempuri.org/IService1/SumOfDigitsResponse")]
        System.Threading.Tasks.Task<int> SumOfDigitsAsync(int sumOfDigits);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReverseAString", ReplyAction="http://tempuri.org/IService1/ReverseAStringResponse")]
        string ReverseAString(string s1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReverseAString", ReplyAction="http://tempuri.org/IService1/ReverseAStringResponse")]
        System.Threading.Tasks.Task<string> ReverseAStringAsync(string s1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HtmlTags", ReplyAction="http://tempuri.org/IService1/HtmlTagsResponse")]
        string HtmlTags(string s1, string s2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HtmlTags", ReplyAction="http://tempuri.org/IService1/HtmlTagsResponse")]
        System.Threading.Tasks.Task<string> HtmlTagsAsync(string s1, string s2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortNumbers", ReplyAction="http://tempuri.org/IService1/SortNumbersResponse")]
        double[] SortNumbers(double n1, double n2, double n3, double n4, double n5);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortNumbers", ReplyAction="http://tempuri.org/IService1/SortNumbersResponse")]
        System.Threading.Tasks.Task<double[]> SortNumbersAsync(double n1, double n2, double n3, double n4, double n5);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortDescNumbers", ReplyAction="http://tempuri.org/IService1/SortDescNumbersResponse")]
        double[] SortDescNumbers(double n1, double n2, double n3, double n4, double n5);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortDescNumbers", ReplyAction="http://tempuri.org/IService1/SortDescNumbersResponse")]
        System.Threading.Tasks.Task<double[]> SortDescNumbersAsync(double n1, double n2, double n3, double n4, double n5);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : assignmentConsole.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<assignmentConsole.ServiceReference1.IService1>, assignmentConsole.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string PrimeNumbers(int number) {
            return base.Channel.PrimeNumbers(number);
        }
        
        public System.Threading.Tasks.Task<string> PrimeNumbersAsync(int number) {
            return base.Channel.PrimeNumbersAsync(number);
        }
        
        public int SumOfDigits(int sumOfDigits1) {
            return base.Channel.SumOfDigits(sumOfDigits1);
        }
        
        public System.Threading.Tasks.Task<int> SumOfDigitsAsync(int sumOfDigits) {
            return base.Channel.SumOfDigitsAsync(sumOfDigits);
        }
        
        public string ReverseAString(string s1) {
            return base.Channel.ReverseAString(s1);
        }
        
        public System.Threading.Tasks.Task<string> ReverseAStringAsync(string s1) {
            return base.Channel.ReverseAStringAsync(s1);
        }
        
        public string HtmlTags(string s1, string s2) {
            return base.Channel.HtmlTags(s1, s2);
        }
        
        public System.Threading.Tasks.Task<string> HtmlTagsAsync(string s1, string s2) {
            return base.Channel.HtmlTagsAsync(s1, s2);
        }
        
        public double[] SortNumbers(double n1, double n2, double n3, double n4, double n5) {
            return base.Channel.SortNumbers(n1, n2, n3, n4, n5);
        }
        
        public System.Threading.Tasks.Task<double[]> SortNumbersAsync(double n1, double n2, double n3, double n4, double n5) {
            return base.Channel.SortNumbersAsync(n1, n2, n3, n4, n5);
        }
        
        public double[] SortDescNumbers(double n1, double n2, double n3, double n4, double n5) {
            return base.Channel.SortDescNumbers(n1, n2, n3, n4, n5);
        }
        
        public System.Threading.Tasks.Task<double[]> SortDescNumbersAsync(double n1, double n2, double n3, double n4, double n5) {
            return base.Channel.SortDescNumbersAsync(n1, n2, n3, n4, n5);
        }
    }
}