using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2Demo
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void ContinueAndBreak() //continue和break的区别
        {
            for(int i=0;i<50;i++)
            {
                if (i == 5)
                    continue;
                else if (i == 10)
                    break;
                Console.WriteLine("This is no.{0}", i);
            }
        }
        static void Goto() //限制使用的goto
        {
            goto flag;
            Console.WriteLine("Aha? A flag?Excuse me?");//warning: unreachable code decteced
            return;
        flag:
            Console.WriteLine("Well,I just saw a flag.");
        }
        static void Return()
        {
            for(int i=0;i<10;i++)
            {
                if (i == 8)
                    return;
                Console.WriteLine("This is no.{0}", i);
            }
            Console.WriteLine("It's done!");
        }
        static void Operators()
        {
            int temp0;
            int a = 10, b = 5, c = 12;
            double d = 3.14;
            float e = 2.33f;
            temp0 = a * b + c * a + 10 / b;
            //temp0=a*a*d-2;		//error
            double temp1 = a * a * d - 2;

            a = 10;
            b = 5;
            c = 12;
            bool temp;
            temp = a == b;
            temp = a != b;
            temp = a >= b;
            temp = a < b;

            bool A = true, B = false, C = false;
            int i = 50, j = 100;
            int k = i & j;
            i = j | k;
            i = j ^ k;
            bool D = A & B;
            D = A ^ B;
            D = A | C;

            a = 15;
            b = a << 4;
            b = a >> 2;

            a = 0;
            b = 100;
            c = -10;
            bool m = true, n = true, l = false;
            c = b;
            a += 100;     
            m&= n;     
            l ^= m;

            i = 0;
            temp = i is int;
            temp = i is float;


            a = 10;
            b = 5;
            temp=a > b ? true:false;
            
        }//运算符
        static void PrintDate(int day,int month=10,int year=2016)
        {
            Console.WriteLine("It's {0}/{1}/{2}", year, month, day);
        }//值传递、默认参数
        static void SwapValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }//值传递
        static void SwapValue(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }//引用传递
        //static void SwapValue(out int x,out int y) //无法定义仅仅有out和ref区别的重载
        //{
        //    x = 1;
        //    y = 2;
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        static void OutSwapValue(out int x, out int y)
        {
            x = 1;
            y = 2;
            int temp = x;
            x = y;
            y = temp;
        }//输出传递
        static int ParamsFuncAdd(params int[] list)
        {
            int temp = 0;
            for (int i = 0; i < list.Length; i++)
            {
                temp += list[i];
            }
            return temp;
        }//数组传递
        static double AverageScore(double Score1,params double[] Score2)//计算平均成绩，如果score1不足3分则不计算
        {
            if (Score1<3)
            {
                return 0;   //不满足条件，返回0
            }
            else
            {
                double temp=0;
                for (int i = 0; i < Score2.Length; i++)
                    temp += Score2[i];
                return temp / Score2.Length;    //返回平均成绩
            }
        }
        static void StringTest()
        {
            string str1 = Console.ReadLine();
            str1 = str1.Replace('G', 'g');
            if (str1.Length > 5)
                str1 = str1.Remove(4, 1).Insert(4, "R");
            else
                str1 += 'R';
            str1 += "---from Windows10";
            Console.WriteLine(str1);
        }//string
        static void StringBuilderTest()//stringbuilder
        {
            string str1 = Console.ReadLine();
            StringBuilder strb1 = new StringBuilder(str1);
            if (strb1.Length > 5)
                strb1 = strb1.Remove(4, 1).Insert(4, "R");
            else
                strb1.Append("R");
            strb1.Append("---from Windows10");
            Console.WriteLine(strb1);
        }
        static void StringAndStringBuilder()
        {
            string lstr = "Microsoft Corporation (commonly referred to as Microsoft or MS) is an American multinational technology company headquartered in Redmond, Washington, that develops, manufactures, licenses, supports and sells computer software, consumer electronics and personal computers and services. Its best known software products are the Microsoft Windows line of operating systems, Microsoft Office office suite, and Internet Explorer and Edge web browsers. Its flagship hardware products are the Xbox video game consoles and the Microsoft Surface tablet lineup. As of 2011, it was the world's largest software maker by revenue,[8] and one of the world's most valuable companies.";
            for(int i=0;i<1000;i++)
            {
                lstr.Insert(10,"G");
            }
            Console.WriteLine("String is done");
            StringBuilder lstrb = new StringBuilder(lstr);//breakpoint
            for (int i = 0; i <1000; i++)
            {
                lstrb.Insert(10, "G");
            }
            Console.WriteLine("StringBuilder is done");//breakpoint
        }

    }
}
