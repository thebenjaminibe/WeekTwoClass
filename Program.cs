using System;

namespace WeekTwoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var myName = "Benjamin";
            var myAge = 30;
            var nairaToDollars = 570.29;
            var anonTypes = new {
                name = "anonymous",
                project = "Dotnet",
                version = 5.0

            };




            Console.WriteLine("Hello World!");
            Console.WriteLine(anonTypes.name);
            Console.WriteLine(anonTypes.project);
            Console.WriteLine(anonTypes.version);
        }
    }
}
