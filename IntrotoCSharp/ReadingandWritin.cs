using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrotoCSharp
{
    class ReadingandWritin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Hello {0}", username);
            Console.ReadKey();
        }
    }
}
