using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class ArrayList1
    {
        
        static void Main()
        {
            PhoneInfo info = new PhoneInfo();
            info.Name = "홍길동";
            info.Phone = "010-1111-2222";
            info.Birth = "0604";
           
            ArrayList alist = new ArrayList();
            alist.Add("사과");
            alist.Add("딸기");
            alist.Add("참외");
            alist.Add("수박");
            alist.Add(123);
            alist.Add(info);
            Console.WriteLine(alist.Count);

            alist.Remove("딸기");
            Console.WriteLine(alist.Count);
            alist.Insert(0, "키위");
            for(int i=0; i<alist.Count; i++)
            {
               if(alist[i] is PhoneInfo)
                {
                    Console.WriteLine(((PhoneInfo)alist[i]).Name);
                }
                else
                {
                    Console.WriteLine(alist[i]);
                }
            }
        }
    }
    public class PhoneInfo : IComparable
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Birth { get; set; }

        public PhoneInfo()
        {

        }
        public PhoneInfo(string name)
        {
            Name = name;
        }

       

        public int CompareTo(object obj)
        {
            PhoneInfo info = (PhoneInfo)obj;
            return this.Name.CompareTo(info.Name);
        }

        public override bool Equals(object obj)
        {
            PhoneInfo info = (PhoneInfo)obj;
            return this.Name == info.Name;
         }

        public override int GetHashCode()
        {
            return EqualityComparer<string>.Default.GetHashCode(Name);
        }
    }
}
