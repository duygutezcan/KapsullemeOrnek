using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.TCKİMLİKNO = "14569875655";
            Console.WriteLine("tc kimlik numaranız: " +P1.TCKİMLİKNO);
        }
    }
}
