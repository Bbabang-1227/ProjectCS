using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using static System.Console;
using System.Collections;

namespace aboutMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // 직각삼각형의 사이각이 30도일때 빗변 / 높이 = sin30

            // 기본상식으로는 1/2가 나와야하는데 안나온다
            // 파이, 라디안 * 3.14 = 180도
            // 30도라고생각하지마라 30라디안이라고 생각해라
            // 30 * 3.14 
            // 180 : 3.14 = 30 : ?
            WriteLine(Math.Sin(DegreeToRadian(30.0)));

            float sum = 0.0f;
            for (int i = 0; i < 100; i++)
            {
                sum += 0.1f;
            }

            WriteLine(sum);

            // 

            //Dictionary 검색특화
            //{1,2} 1.key 2.value
            Hashtable user = new Hashtable();
            user.Add("1", "방현준");
            user.Add("2", "아르카나");
            user.Add("3", "데모닉");
            WriteLine(user.Count);

            //제거
            user.Remove("2");
            WriteLine(user.Count);

            //Delete all
            //user.Clear();
            //WriteLine(user.Count);

            //값을 가지고 있는가? 검색
            WriteLine(user.Contains("1"));
            WriteLine(user.Contains("2"));

            WriteLine("---------------------------");
            //read
            WriteLine(user["1"]);
            WriteLine(user["2"]);
            WriteLine("---------------------------");

            user.Add("4", "바드");
            ICollection keys = user.Keys;
            ICollection values = user.Values;

            foreach ( var key in keys)
            {
                Write(key + " ");
            }WriteLine();

            foreach (var value in values)
            {
                Write(value + " ");
            }
            WriteLine();
            WriteLine("---------------------------");
            //데이터 갱신 update
            user["1"] = "스카우터";
            user["2"] = "워로드";
            foreach (var value in values)
            {
                Write(value + " ");
            }
            WriteLine();

            //
            WriteLine("---------------------------");
            WriteLine(user["2"]);
            string s = user["2"].ToString();

            foreach (DictionaryEntry value in user)
            {
                //Write("{0} \t {1}", value.Key, value.Value);
                
                WriteLine($"{value.Key} \t {value.Value}");
            }
            WriteLine();

            Clear();

            foreach (var item in user.Values)
            {
                WriteLine(item);
            }

            WriteLine(user.ContainsValue("바드"));

            //Key값은 고유해야한다 중복x
            //user.Add("1", "중복키에데이터넣어보기");
            Clear();


            //SortedList
            //키값을 기준으로 정렬
            SortedList sl = new SortedList();
            sl.Add("나", "이즈리얼");
            sl.Add("가", "진");
            sl.Add("다", "카르마");
            sl.Add("라", "세트");

            foreach (DictionaryEntry item in sl)
            {
                WriteLine($"{item.Key} \t {item.Value}");
            }


            WriteLine("---------------------------");
            //데이터 갱신
            sl.Add("마", "초가스");
            sl["마"] = "럭스";

            foreach (DictionaryEntry item in sl)
            {
                WriteLine($"{item.Key} \t {item.Value}");
            }

            WriteLine("---------------------------");
            sl.SetByIndex(1,"블리츠크랭크");

            foreach (DictionaryEntry item in sl)
            {
                WriteLine($"{item.Key} \t {item.Value}");
            }

            WriteLine("---------------------------");
            //삭제
            sl.RemoveAt(0);
            foreach (DictionaryEntry item in sl)
            {
                WriteLine($"{item.Key} \t {item.Value}");
            }
            WriteLine("---------------------------");
            WriteLine(sl.GetByIndex(2));
            Clear();

            //ILIST
            IList ilkeys = sl.GetKeyList();
            IList ilvalue = sl.GetValueList();
            foreach (var item in values)
            {

            }
        }
        static double DegreeToRadian(double degree)
        {
            return Math.PI*degree / 180.0;
        }
    }
}
