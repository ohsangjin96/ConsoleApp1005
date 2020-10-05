using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class List1
    {
        static void Main()
        {
            List<string> list = new List<string>();

            list.Add("김치찌개");
            list.Add("김치찌개");
            list.Add("김치찌개");
            list.Add("김치찌개");
            list.Add("김치찌개");

            string[] arr=list.ToArray();
            int[] strarr = new int[3] { 10, 20, 30 };
            List<int> ilList = strarr.ToList<int>();
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
