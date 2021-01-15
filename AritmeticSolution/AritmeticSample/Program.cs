using System;

namespace AritmeticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //the special character \n adds an extra blank line
            //it is called the next line character
            Console.WriteLine("Arithmetic Samples\n");

            //declare a variable of datatype double
            //syntax;  datatype variablename assignment operator literal numeric value;
            //                 double                =                 0,0;
            double Total = 0.0;
            double Cost = 15.23;
            double Tax = 0.81;
            
            //arithmetic assignment operation
            //syntax; receiving variable assignment operator binary arithmetic expression (Addition)
            //                Total                =                Cost + Tax;
            //action: the expression will be executed and the result will be placed
            //into the receiving variable
            Total = Cost + Tax;

            Console.WriteLine($"The result of {Cost} + {Tax} is {Total}");
        }
    }
}
