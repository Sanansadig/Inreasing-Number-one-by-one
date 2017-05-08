using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtanReqem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci ededi daxil edin");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ikinci ededi daxil edin");
            int m = Convert.ToInt32(Console.ReadLine());
            int v = (n / 100);
            int i;
            int k = m/n;
            for (i=0; i< k-1; i++)
            {
                 int j =100 * (v + i) + (v + i + 1) * 10 + (v + i + 2);
                Console.WriteLine(j);
            }
            Console.Read();
        }
    }
}