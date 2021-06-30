using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CS_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 제어문 기본구조 자동완성 = tab * 2
            //출력
            WriteLine("{0}, {1} = 스코프값으로 값을 치환 ", 20, 10);
            WriteLine("-------------------------------");
            WriteLine("{0:d4}, {1:d3} = .d(int) 자릿수설정 ", 20, 10);
            WriteLine("-------------------------------");
            WriteLine("{0:x}, {1:x} = .x 16진수로 설정 ", 20, 10);
            WriteLine("-------------------------------");
            int a = 10; int b = 10;
            WriteLine($"{a} , {b}");
            //Clear();
            WriteLine("-------------------------------");
            WriteLine("Clear() 위 코드를 모두 콘솔에서 지움");
            WriteLine("-------------------------------");

            // 0101 0111
            WriteLine(10);
            WriteLine(0x10);
            WriteLine(0b10);
            WriteLine(0b_0101_0111);


            //foreach (var item in collection) // 이게 뭐노?
            //{
            //
            //}

            // data type
            byte b1 = 2; // 0 ~ 255
            sbyte b2; // -128 ~ 127
            short b3; //
            ushort us; // 양수형 숏
            uint ui; // 4byte
            long l; ulong ul;
            string vs; // cs에서 char타입은 2바이트
            float fl = 3.14f; // 4byte
            double db = 3.14; // 8byte
            decimal de = 3.14m; // 16byte
            bool bo = false;
            var va = 10;
            object ob;
            dynamic dy;

            a = (int)b1;
            WriteLine(a);
            WriteLine("-------------------------------");
            WriteLine("-------------------------------");
            // 논리연산
            //xor 하나만 트루일때 트루 반환 
            WriteLine(false ^ false);
            WriteLine(false ^ true);
            WriteLine(true ^ false);
            WriteLine(true ^ true);
            //삼항연산자
            int c = a > b ? a : b;
            WriteLine(c);
            WriteLine(c >= 10 ? "true" : "false");
            int num = -10;
            int abs = num >= 0 ? num : -num;

            Tiger t1 = new Tiger();
            Tiger t2 = null;
            t2 = new Tiger();
            t2 = null;
            
            //nullable  널 허용값 형식
            int? c2 = null;
            c2 = 100;
            WriteLine(c2);
            c2 = null;
            int? b4 = 20;
            WriteLine(c2);
            //값이 존재하는지에 대해
            WriteLine(c2.HasValue);

            try
            {
                WriteLine(c2.Value);
            }
            catch (Exception e)
            {
                WriteLine(c2.GetValueOrDefault());
                WriteLine(c2.GetValueOrDefault(500));
            }
            WriteLine(c2);
            WriteLine("program closed");

            //null 통합연산
            WriteLine("null 통합연산");
            WriteLine(c2 == null ? -1 : c2);
            WriteLine(c2 ?? -1);
            WriteLine(b4 ?? -1);
            WriteLine("-------------------------------");
            char ca = 'A';
            char cb = (char)65;
            //string 클래스는 갱신이 안됨 눈에만 갱신되는것처럼 보이지만 메모리로스가 일어남
            string s1 = "방현준";
            WriteLine(s1);
            s1 = "아이폰";
            WriteLine(s1);

            //문자열
            WriteLine("-------------------------------");
            StringBuilder s;
            string s2 = new string('0', 30);
            WriteLine(new string('0',20));
            string sa = "호랑이";
            sa += s2;
            WriteLine("d" == "d");

            //치환
            WriteLine("-------------------------------");

            //str -> int
            string str = "2000";
            int sti = Convert.ToInt32(str);
            WriteLine("int : " + sti);

            //int -> str
            WriteLine("str : " + sti.ToString());
            //천단위로 콤마를 찍어줌
            WriteLine("str : " + sti.ToString("n0"));
            //16진수로 치환
            WriteLine("str : " + sti.ToString("x"));
            //남는칸만큼 0으로 채움
            WriteLine("str : " + sti.ToString("000000"));


            //string format
            string str2 = string.Format("{0}년,{1}월,{2}일" , 2021 , 06 , 30);
            WriteLine(str2);

            //Trim 중간의 공백,문자들을 없앨 방법은 없다 따로 함수를 짜야해
            char[] charsToTrim = { '*', ' ', '\'' };
            string banner = "*** Much Ado About Nothing ***";
            string input = "         w *e *a*r* e* \'the\' o ne";
            string result = banner.Trim(charsToTrim);
            WriteLine("Trimmmed\n   {0}\nto\n   '{1}'", banner, result);

            string result2 = input.Trim(charsToTrim);
            WriteLine("Trimmmed\n   {0}\nto\n   '{1}'", input, result2);
            WriteLine(banner);

            WriteLine("-------------------------------");

            //padding
            string str3 = "1";
            string str4 = "10";
            string str5 = "100";
            WriteLine(str3.PadLeft(8,'ㅋ')); WriteLine(str3.PadRight(8));
            WriteLine(str4.PadLeft(8)); WriteLine(str4.PadRight(8,'ㅋ'));
            WriteLine(str5.PadLeft(8, 'ㅋ')); WriteLine(str5.PadRight(8));

            string str6 = "TigerWin";
            WriteLine(str6.ToUpper());
            WriteLine(str6.ToLower());

            WriteLine("-------------------------------");
            //Concat 이어붙이기
            WriteLine(string.Concat(str3, str4));
            //문자열삽입 인덱스값에 대입
            WriteLine(str6.Insert(5, "방현준"));
            //인덱스부터 후행까지 제거
            WriteLine(str6.Remove(5));
            //인덱스부터 , 갯수까지 제거
            WriteLine(str6.Remove(5, 2));

            //탐색후수정 대소문자 구별
            WriteLine(str6.Replace("Tiger", "Dog"));

            //해쉬코드를 얻는다는데 뭔소리지
            WriteLine(str6.GetHashCode());

            string str7 = "방현준";
            string str8 = "로스트아크";

            WriteLine(str7.CompareTo(str8) == 0 ? "똑같아" : "달라");
            WriteLine(String.Compare(str7, str7) == 0 ? "똑같아" : "달라");
            WriteLine("-------------------------------");
            //대소문자 구분 compare,equal
            WriteLine(string.Compare("Tiger","tiger",true) == 0 ? "똑같아" : "달라");
            WriteLine(string.Compare("Tiger", "tiger", false) == 0 ? "똑같아" : "달라");

            WriteLine("-------------------------------");
            string str9 = "집에가서 게임하고 자고싶다";
            //함수처럼 생기지않아도 함수기능을 하는것
            //멤버 변수도 아니다 , 프로퍼티(속성)
            WriteLine(str9.Length);

            //cs에서의 getter setter
            Tiger t = new Tiger();
            //setter 자동호출
            t.Num = 1000;
            //getter 자동호출
            WriteLine(t.Num);
            WriteLine("-------------------------------");

            //문자열탐색
            WriteLine(str6.IndexOf("Tiger"));
            WriteLine(str6.LastIndexOf("Tiger"));
            WriteLine(str6.Contains("Tiger"));
            int[] ar = { 0, 1, 2, 3, 4, 5 };
            foreach (int item in ar)
            {
                Write(item + " ");
            }
            WriteLine();
            //메모리를 공유 , 생성이아니다 , 얕은복사
            int[] ar4 = ar;
            ar4[0] = 999;
            WriteLine(ar[0]);
            //깊은 복사
            int[] ar5 = (int[])ar.Clone();
            ar5[1] = 222;
            WriteLine(ar[1] + " " +  ar5[1]);

            //cs 에서의 2차원배열
            int[,] ar6 = new int[2, 3]; // = ar[2][3]
            ar6[0, 0] = 1;
            ar6[0, 1] = 2;
            ar6[0, 2] = 3;
            ar6[1, 0] = 4;
            ar6[1, 1] = 5;
            ar6[1, 2] = 6;
            foreach (int item in ar6)
            {
                WriteLine(item);
            }
        }
        int m1(int a, int b) 
        {
            return a > b ? 100 : 200;
        }
        class Tiger
        {
            int num;
            //Num = 속성
            //getter setter가 단순하고 쉬워짐
            public int Num
            {
                set;
                get;
                /*set {
                    WriteLine("set call");
                    num = value; }
                get {
                    WriteLine("get call");
                    return num; }*/
            }
            /*
            public void setter(int num)
            {
                this.num = num;
            }
            public int getter()
            {
                return this.num;
            }*/
        }
    }
}
