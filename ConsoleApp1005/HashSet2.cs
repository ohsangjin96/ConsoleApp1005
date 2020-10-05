using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class HashSet2
    {
        static void Main()
        {
            HashSet<string> sets = new HashSet<string>();
            sets.Add("홍길동");
            sets.Add("김길동");
            sets.Add("홍길동");

            Console.WriteLine(sets.Count);

            HashSet<PhoneInfo> person = new HashSet<PhoneInfo>();
            person.Add(new PhoneInfo("홍길동"));
            person.Add(new PhoneInfo("김길동"));
            person.Add(new PhoneInfo("홍길동"));

            
            Console.WriteLine(person.Count);
        }
       
    }
}
