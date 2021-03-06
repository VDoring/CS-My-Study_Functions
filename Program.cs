﻿using System;

namespace CS_StudyLog
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 기본 출력들 */
            Console.Write("이것이.. C#이란것인가? "); //Console.Write는 일반적인 출력
            Console.WriteLine("Hello World!"); //Console.WriteLine은 출력후 다음 줄로 넘어간다
            Console.WriteLine("자동 띄어쓰기!");

            Console.Write('H'); //문자는 여러개가 아닌 한개의 문자로만 이루어진다. ('' 사용)
            Console.Write('i');
            Console.Write('!');
            Console.WriteLine("111"); // "111"은 문자열("")
            Console.WriteLine(111); // 111은 정수 ("" 없음)

            Console.WriteLine(1+5); // 6
            Console.WriteLine(3.14+3.14); //6.28
            Console.WriteLine(2 * 3); // 6
            Console.WriteLine(10 / 2); //5
            Console.WriteLine(10 % 5); // 0

            Console.WriteLine("안녕하신가? 나는\"Git\"이라고 하네"); // 콘솔창에 " 출력 OK
            Console.Write("안만나서럽다 못반갑판네"[1]); //"" 뒤에 [숫자]를 적어주면 특정 글자만 출력하게 할수도 있디.
            Console.Write("안만나서럽다 못반갑판네"[2]); //물론, 배열처럼 0부터 시작한다.
            Console.Write("안만나서럽다 못반갑판네"[3]);
            Console.Write("안만나서럽다 못반갑판네"[6]);
            Console.Write("안만나서럽다 못반갑판네"[8]);
            Console.Write("안만나서럽다 못반갑판네"[9]);
            Console.WriteLine("안만나서럽다 못반갑판네"[11]); //만나서 반갑네  최종 출력

            Console.WriteLine(true); //bool도 사용가능!
            Console.WriteLine(false);

            Console.WriteLine(2 < 3); //True
            Console.WriteLine(2 > 3); //False
            Console.WriteLine(!(2 < 3)); //False. true지만 !때문에 false이다
            Console.WriteLine((2<3)||(2<1)); //True. OR연산자 특성상 한쪽이 True면 True이다
            Console.WriteLine((2 < 3) && (2 < 1)); //False. AND연산자 특성상 모두 True가 아니면 False이다.
            Console.Write("\n\n");

            /*변수 사용하기*/
            int a = 10, b = 20;
            Console.WriteLine(a + b); // 30
            Console.WriteLine(a - b); // -10
            a = a + 1;
            Console.WriteLine(a); // 11

            float fa = 3.14f, fb = 5.2f;
            double da = 3.18, db = 5.4;
            Console.WriteLine(fa + fb); // 8.34
            Console.WriteLine(da + db); // 8.58

            char ar = 'a';
            Console.WriteLine(ar);

            string arr_1 = "a~ 이것이 ";
            string arr_2 = "문자열이란 거구나~";
            Console.WriteLine(arr_1 + arr_2); // a~ 이것이 문자열이란 거구나~
            Console.Write(arr_1[3]); // 이
            Console.Write(arr_1[3]); // 이
            Console.Write(arr_2[8]); // 나
            Console.WriteLine(arr_2[9]); // ~

            bool bool_a = 1 > 0;
            bool bool_b = 1 < 0;
            Console.WriteLine(bool_a); // True
            Console.WriteLine(bool_b); // False

            int c = 10, d = 5;
            c += d; // c = 15
            Console.WriteLine(c); /// 15
            c *= d; // c = 15 * 5
            Console.WriteLine(c); // 75

            int e = 0;
            Console.WriteLine(e++); // 0 출력
                                    //후위. 해당 줄의 코드를 실행 한 다음에 계산
            Console.WriteLine(e); // 1 출력
            Console.WriteLine(--e); // 0 출력
                                    // 전위. 계산 후 코드 실행
            Console.WriteLine(e); // 0 출력

            /* 자료형은 무엇이 있나?
            [정수]
            sbyte
            byte
            char
            short
            ushort
            int
            uint
            long
            ulong

            [실수]
            float
            double

            <참고로 var를 사용하면 자료형을 알아서 정해준다. C언어엔 없는 사기급 기술..!>
            var a = 10;
            var b = 3.14;
            var c = 'i';
            var d = "Night";
            */


            /*값 입력받기*/
            string Readarr = Console.ReadLine();
            Console.WriteLine("당신은 방금 " + Readarr + "를 입력했습니다.");


            var aa = 20;
            var bb = 2.71;
            var cc = 'p';
            var dd = "Daylight";

            int integer_a = (int)bb;
            Console.WriteLine(integer_a);

            string testString = "123";
            int.Parse(testString); //만약 testString에 "abc"같은 문자가 저장될경우 에러가 발생한다.
            Console.WriteLine(testString); //숫자(형)으로 바꼈다.

            int _pi = 314;
            string _pistr = (_pi).ToString();
            Console.WriteLine(_pistr);

            int aaa = 8, bbb = 5;
            bool ccc = aaa < bbb;
            Console.WriteLine(ccc); //FALSE 출력

            bool a_bool = true;
            bool b_bool = false;
            Console.WriteLine(a_bool && b_bool); //a와 b가 참이다를 만족하지 않음. FALSE
            Console.WriteLine(a_bool && !b_bool); //a와 b가 참이다를 만족하므로 TRUE
            Console.WriteLine(a_bool || b_bool); //a 또는 b중 참이다를 만족하므로 TRUE

            int score = Convert.ToInt32(Console.ReadLine());
            if (score == 100) Console.WriteLine("100점 축하");
            else if (score >= 90) Console.WriteLine("90점 이상 축하");
            else if (score >= 80 && score < 90) Console.WriteLine("80점 이상 일단 축하");
            else Console.WriteLine("노력해");

            for(int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i+ "x" + j + "=" + i*j);
                }
            }

            string BloodType = Console.ReadLine();
            switch(BloodType)
            {
                case "A":
                    Console.WriteLine("A형, O형에게 수혈받을 수 있음");
                    break;
                case "B":
                    Console.WriteLine("B형, O형에게 수혈받을 수 있음");
                    break;
                case "AB":
                    Console.WriteLine("모든 혈액형 수혈가능");
                    break;
                case "O":
                    Console.WriteLine("O형에게 수혈가능");
                    break;
                default:
                    Console.WriteLine("혈액형을 대문자로 입력해");
                    break;
            }

        }
    }
}

// http://blog.naver.com/PostView.nhn?blogId=einsbon&logNo=221133419991&parentCategoryNo=&categoryNo=15&viewDate=&isShowPopularPosts=false&from=postList
// 이후 여기서부터 진행