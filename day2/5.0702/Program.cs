using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using static System.Console;
using System.Collections;

namespace _5._0702
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue
            Queue q = new Queue();
            q.Enqueue("Msg1");
            q.Enqueue("Msg2");
            q.Enqueue("Msg3");
            WriteLine(q.Count);

            while (q.Count != 0)
            {
                string s = q.Dequeue().ToString();
                WriteLine(q.Count + "" + s);
            }
            WriteLine("exit");
            q.Enqueue("Msg1");
            q.Enqueue("Msg2");
            q.Enqueue("Msg3");
            string s2 = q.Peek().ToString();
            WriteLine(q.Count + " " + s2);
            //큐를 비운다
            //q.Clear();

            object[] ar = q.ToArray();
            WriteLine(q.Count);
            WriteLine("---------------------");
            foreach (string item in ar)
            {
                WriteLine(item);
            }
            q.Clear();
            ArrayList al = new ArrayList();
            al.Add("MSG 10");
            al.Add("MSG 20");
            al.Add("MSG 30");

            q.Enqueue(al);
            q.Clear();
            Clear();
            //Stack
            Stack st = new Stack(al);
            WriteLine(st.Count);
            st.Push(40);
            st.Push(50);
            WriteLine("----------------------");
            WriteLine(st.Count);
            while (st.Count != 0)
            {
                object ob = st.Pop();
                Write(ob + " ");
                WriteLine(st.Count);
            }

            st.Push(10);
            st.Push(20);
            st.Push(30);
            //peek = 맨 위의 개체를 스텍에서 삭제하지않고 출력
            int num = (int)st.Peek();
            WriteLine(num);

            WriteLine("--------스택에서 삭제하지않고 데이터추출------");
            object[] ob2 = st.ToArray();
            foreach (object item in ob2)
            {
                WriteLine(item);
            }
            WriteLine(st.Count);
            Clear();
            WriteLine("----------------------");
            //bitarray
            BitArray barr = new BitArray(new bool[] { true, false, true, false });

            foreach (bool item in barr)
            {
                WriteLine(item);
            }

            barr.Not();
            WriteLine("----------------------");
            foreach (bool item in barr)
            {
                WriteLine(item);
            }

            WriteLine("----------------------AND");
            BitArray barr2 = new BitArray(new bool[] { true, false, true, false });
            BitArray barr3 = new BitArray(new bool[] { true, false, true, false });
            foreach (bool item in barr2.And(barr3))
            {
                WriteLine(item);
            }
            WriteLine("----------------------OR");
            foreach (bool item in barr2.Or(barr3))
            {
                WriteLine(item);
            }
            WriteLine("----------------------XOR");
            foreach (bool item in barr2.Xor(barr3))
            {
                WriteLine(item);
            }
            Clear();

            f5("방현준" , 23 ,"방현준");

            string str = "스트링타입";
            char[] carr = str.ToCharArray();
            foreach (object item in carr)
            {
                Write(item);
            }WriteLine();
            Array.Reverse(carr);
            WriteLine(carr);
            Clear();

            WriteLine(carr.Length);
            WriteLine(carr);
            swap(carr);

            Clear();

            //GUID 생성
            object[] idob = new object[10];
            for (int i = 0; i < 10; i++)
            {
                //option N , D(기본) , B , P
                idob[i] = Guid.NewGuid().ToString("P");
            }
            foreach (object item in idob)
            {
                WriteLine(item);
            }
            WriteLine("----------------------");
            Clear();

            Random ran = new Random();
            int o = 0;
            int omax = 0;
            int x = 0;
            int xmax = 0;
            for (int i = 0; i < 10; i++)
            {
                if(ran.Next(0,2) % 2 == 0)
                {
                    ++o;
                    if (omax < o)
                    {
                    omax = o;
                    }
                    x = 0;
                    Write("O");
                }
                else
                {
                    ++x;
                    if (xmax < x)
                    {
                        xmax = x;
                    }
                    o = 0;
                    Write("X");
                }
            }WriteLine();
            WriteLine(omax + " " + xmax);
        }

        //params[] 를 전달인수로 가지고있는 함수
        // 함수 호출시 지정된 전달인수를 제외하고 추가적으로 전달할게 있다면 유용할듯
        static void f5(string s , params object[] p)
        {
            foreach (object item in p)
            {
                WriteLine(item);
            }
        }

        static void swap(char[] carr)
        {
            for (int i = 0; i <= carr.Length / 2; i++)
            {
                char temp = carr[i];

                carr[i] = carr[carr.Length - i - 1];
                carr[carr.Length - i - 1] = temp;
            }
            WriteLine(carr);
        }
    }
}
