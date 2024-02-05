using System.Diagnostics;

namespace AssignmentDeclareDeconstruction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = (Name: "Greg Esguerra", Address: "Cebu City Philippines");
            //deconstruct
            (string name, string address) = student;
            Console.WriteLine(name);
            Console.WriteLine(address);

            //C# 10 version 
            Console.WriteLine("\nC# 10 version");
            string nameOne;
            (nameOne, string addressOne) = student;
            Console.WriteLine(nameOne);
            Console.WriteLine(addressOne);

            Console.ReadLine();
        }
    }
}
