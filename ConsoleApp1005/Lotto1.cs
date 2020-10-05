using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class Lotto1
    {
        static void Main()
        {
            List<int> lotto = new List<int>();
            Random rand = new Random();

            
            while (true)
            {
                int temp = rand.Next(1, 47);
                if(!lotto.Contains(temp))
                  lotto.Add(temp);
              

                if (lotto.Count > 5) break;

            }
            foreach(int item in lotto)
            {
                Console.Write(item+" ");
            }
        }
    }
}
