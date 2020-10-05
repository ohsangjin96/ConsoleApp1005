using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class HashSet1
    {
        static void Main()
        {
            HashSet<int> lotto = new HashSet<int>();
            Random rand = new Random();

            while (true)
            {
                lotto.Add(rand.Next(1, 47));

                if (lotto.Count > 6) break;
            }
            int[] a_lotto = lotto.ToArray();
            Array.Sort(a_lotto);

            foreach(int item in a_lotto)
            {
                Console.Write(item+ " ");
            }
        }
    }
}
