using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            //string[] name = new string[5];
            //for (int i = 0; i < name.Length; i++)
            //{
            //    name[i] = Console.ReadLine();
            //}
            //foreach (string name1 in name)
            //{
            //    Console.WriteLine(name1);
            //}
            //string[,] personArr = new string[2, 2];
            //for (int i = 0; i < personArr.GetLength(0); i++)
            //{
            //    Console.Write("이름: ");
            //    personArr[i, 0] = Console.ReadLine();
            //    Console.Write("번호: ");
            //    personArr[i, 1] = Console.ReadLine();
            //}
            //for (int i = 0; i < personArr.GetLength(0); i++)
            //{
            //    Console.WriteLine($"{personArr[i, 0]}님의 번호는 {personArr[i, 1]} 입니다.");
            //}
            //PhoneInfo[] pArr = new PhoneInfo[5];
            //for (int i = 0; i < pArr.Length; i++)
            //{
            //    PhoneInfo Info = new PhoneInfo();
            //    Console.Write("이름: ");
            //    Info.Name = Console.ReadLine();
            //    Console.Write("번호: ");
            //    Info.Phone = Console.ReadLine();
            //    Console.Write("생일: ");
            //    Info.Birth = Console.ReadLine();
            //    pArr[i] = Info;
            //}
            //foreach (PhoneInfo info in pArr)
            //{
            //    Console.WriteLine($"{info.Name},{info.Phone},{info.Birth}");
            //}
            //입력하는대로 모두 저장했다가,출력해보세요

            //ArrayList 사용

            //ArrayList list = new ArrayList();
            //while (true)
            //{
            //    PhoneInfo info = new PhoneInfo();
            //    Console.Write("이름: ");
            //    info.Name=Console.ReadLine();       
            //    Console.Write("번호: ");
            //    info.Phone = Console.ReadLine();
            //    Console.Write("생일: ");
            //    info.Birth = Console.ReadLine();
            //    list.Add(info);
            //    Console.WriteLine("그만 입력하시겠습니까:(1.Yes / 2. No)");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    if (a == 1)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            //for(int i=0; i<list.Count; i++)
            //{
            //    Console.WriteLine($"이름: {((PhoneInfo)list[i]).Name} 번호: {((PhoneInfo)list[i]).Phone} 생일: {((PhoneInfo)list[i]).Birth}");
            //}

            

            //Generic 사용
            List<PhoneInfo> alist = new List<PhoneInfo>();
            while (true)
            {
                PhoneInfo info = new PhoneInfo();
                Console.Write("이름: ");
                info.Name = Console.ReadLine();
                Console.Write("번호: ");
                info.Phone = Console.ReadLine();
                Console.Write("생일: ");
                info.Birth = Console.ReadLine();
                alist.Add(info);
                Console.WriteLine("그만 입력하시겠습니까:(1.Yes / 2. No)");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i < alist.Count; i++)
            {
                Console.WriteLine($"이름: {((PhoneInfo)alist[i]).Name} 번호: {((PhoneInfo)alist[i]).Phone} 생일: {((PhoneInfo)alist[i]).Birth}");
            }

        }
    }
}
