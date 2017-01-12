using PasswordGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Generator.PasswordGenerator(10));
        }
    }
}
