using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using static System.Console;
using System.Collections;

namespace Test
{
    class Star
    {
        public int id;
        public int Id { get; set; }
        public int age;
        public int Age { get; set; }
        public Star(int id, int age)
        {
            this.id = id;
            this.age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            ArrayList al = new ArrayList();
            int ct = 0;
            while (true)
            {
                //조건에 따라서 랜덤하게 데이터 삭제
                for (int i = 0; i < al.Count;)
                {
                    if(rand.Next(2) == 0)
                    {
                        al.RemoveAt(i);
                    }
                    else
                    {
                        ((Star)al[i]).age++;
                        i++;
                    }
                }

                //데이터 추가
                while (al.Count < 10) 
                {
                    al.Add(new Star(ct++,0));
                }

                foreach (Star item in al) Write("{0:d2} ", item.id);
                WriteLine();
                foreach (Star item in al) Write("{0:d2} ", item.age);
                WriteLine();
                //키 입력조건
                Write("숫자를 입력하세요 exit = 99 : ");
                int input = int.Parse(ReadLine());
                WriteLine();
                if (input == 99) break;
            }
        }
    }
}

