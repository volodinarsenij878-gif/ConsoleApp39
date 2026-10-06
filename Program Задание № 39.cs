using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int big = 300;
            byte small = (byte)big;

            Console.WriteLine($"Исходное int: {big}");
            Console.WriteLine($"Результат byte: {small}");

            Console.WriteLine($"Объяснение: 300 в двоичном виде {Convert.ToString(big, 2).PadLeft(16, '0')}");
            Console.WriteLine($"byte хранит 8 бит: {Convert.ToString(small, 2).PadLeft(8, '0')}");
            Console.WriteLine($"300 mod 256 = {300 % 256}");
        }
    }
}
