using System;

namespace IntrotoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is try catch block for error handling
            try
            {
                //adding the cooment line
                Console.WriteLine("Welcome to C# Programming");
                Console.ReadKey();

            }

            catch
            {
                Console.WriteLine("Error Occured");
            }
        }
    }
}
