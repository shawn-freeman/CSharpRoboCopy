using ClassLibrary1;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var wrapper = new RobocopyWrapper();

            //Example Useage
            //var result = wrapper.CallRoboCopy("\"c:\\_repos\\New folder 2\"", "\"c:\\_repos\\New folder\"", "*", "/e");
            var result = wrapper.CallRoboCopy("{SOURCE}", "{DESTINATION]", "{FILE}", "{OPTIONS}");

            Console.WriteLine(result);
        }
    }
}
