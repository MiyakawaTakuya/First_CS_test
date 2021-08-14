using System;

namespace FirstCSr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C# !" + "Hasta La Vista, baby!!");
            //  数値の表示
            Console.Write(123);
            Console.WriteLine(456);
            Console.WriteLine(789);
            //  文字列の表示
            Console.Write("ABC");
            Console.WriteLine("DEF");

            Console.WriteLine("{0} + {1} = {2}", 5, 2, 5 + 2);  //  足し算
            Console.WriteLine("{0} - {1} = {2}", 5, 2, 5 - 2);  //  引き算
            Console.WriteLine("{0} * {1} = {2}", 5, 2, 5 * 2);  //  掛け算
            Console.WriteLine("{0} * {1} = {2} 余り {3}", 5, 2, 5 / 2, 5 % 2);//  割り算と剰余

            int a;           // 変数の宣言
            int b = 3;      //  初期化と代入を同時に行う。
            int add, sub;    //  複数の変数を同時に宣言
            double avg;     //  int以外の変数を宣言
            a = 6;  //  代入（最初に値を入れるので、”初期化”と言う。
            add = a + b;            //  a,bの和を求める。
            sub = a - b;            //  a,bの差を求める。
            avg = (a + b) / 2.0;    //  a,bの平均値を求める。
            Console.WriteLine("{0} + {1} = {2}", a, b, add);
            Console.WriteLine("{0} - {1} = {2}", a, b, sub);
            Console.WriteLine("{0}と{1}の平均値{2}", a, b, avg);


            int c, d;	//← 変数c,dを宣言
            c = 9;
            d = 11;
            Console.WriteLine("{0}と{1}の平均値は{2}となります", c, d, 10);

            int e = 100, f = 102;	//← 変数e,fを宣言
            Console.WriteLine("{0}と{1}の平均値は{2}となります", e, f, 101);

            // 使用する変数の定義
            int a1 = 2, b1 = 2, c1 = 2, d1 = 2;    // 変数の宣言(1)
            int a2 = 2, b2 = 2, c2 = 2, d2 = 2;    // 変数の宣言(2)
            //  普通の演算による計算と代入
            a1 = a1 + 1;
            b1 = b1 - 1;
            c1 = c1 * 2;
            d1 = d1 / 2;
            //  代入演算による計算
            a2 += 1;
            b2 -= 1;
            c2 *= 2;
            d2 /= 2;
            Console.WriteLine("a1={0} b1={1} c1={2} d1={3}", a1, b1, c1, d1);
            Console.WriteLine("a2={0} b2={1} c2={2} d2={3}", a2, b2, c2, d2);


        }
    }
}
