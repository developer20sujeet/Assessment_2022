using System;
using System.Net.Http;
using PrjRestApi.John;
using Newtonsoft;

namespace PrjRestApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           string s = RestCaller.getPhoneNumber("Afghanistan");
        }
    }
}
