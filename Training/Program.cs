//using System;


//namespace Training
//{
//    class Program
//    {
//        static void Main( )
//        {

//            //    int x = Factorial(9);
//            //    Console.WriteLine(x);



//            //static int Factorial(int n)
//            //{
//            //    if (n == 0)
//            //        return 1;
//            //    else
//            //        return n * Factorial(n - 1);


//            //}

//            for (int i = 6; i < 9; i++)
//            {
//                Console.WriteLine($"{i} - {i * i}");
//            }

//            Console.ReadKey();

//            int i;
//            while



//        }

//    }
//}




using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Progrsm
{


    public static class Program
    {
        //public static void Main()
        //{
        //        //  string b = Remove_char();
        //    Console.WriteLine(b);

        //}

        //private static string Remove_char()
        //{
        //    string s = "Даник";
        //    return s.Substring(1, (s.Length - 2));


        //string s = "cocacola";
        //int s1 = s.Length - 1;
        //s = s.Substring(s1);
        //return s;
        //}   



        //int[] numbers;
        //numbers = new int[5] { 19, 5, 2, 6, 45 };


        //int min = numbers[0], minIndex = 0;

        //for (int i = 0; i < numbers.Length ;i++)
        //{ 
        //        if (numbers[i] < min)
        //    {
        //        numbers[i] = min;
        //        minIndex = i;
        //    }

        //}

        //    int big = numbers[4];

        //    int sum = min + big;
        //    Console.WriteLine(sum);


        // for (int i = 0; i < num.Length; i++)
        //     num[i] = i * 2;
        //for (int i = 0; i< num.Length; i++)
        // Console.WriteLine( num[i]);
        //string str = "123";
        //int number = int.Parse(str); // Вася уверен, что ошибка где-то тут
        //Console.WriteLine(number + 1);
        //{

        //    Console.WriteLine("Введите ваш год ");
        //    СenturyFromYear();


        //}

        //public static void СenturyFromYear()
        //{
        //    int year = int.Parse(Console.ReadLine());
        //    if (year % 100 == 0)
        //    {
        //       Console.WriteLine (year / 100);
        //    }
        //    if (year % 100 != 0)
        //    {
        //        Console.WriteLine ((year / 100) + 1);
        //    }

        //        }

        //}


        //if (medium > myValue)
        //{
        //    Console.WriteLine(false);
        //}
        //else
        //{
        //    Console.WriteLine(true);
        //}


        //int num = 123456789;


        //int nums = int.Parse(new string(num.ToString().OrderByDescending(x => x).ToArray()));
        //Console.WriteLine(nums);


        //string str = "Love";
        //for (char c = 'A'; c <= 'Z'; c++) ;

        //int  n = int.Parse(Console.ReadLine());
        //int sum = 0;
        //int b = 0;
        //for (int i = 1; i <= n; i++)

        //{
        //    sum += i;
        //    b += sum;


        //}

        //Console.WriteLine(b);
        private static void Main()
        {
            string text = "Алгоритм удаления гласных букв из строки без использования методов класса String";
            string vowels = "ауоыиэяюёеАУОЫИЭЯЮЁЕ";

            string result = "";
            for (int i = 0; i < text.Length; i++)
                if (!Contains(text[i], vowels))
                    result += text[i];

            Console.WriteLine(result);

            static bool Contains(char symbol, string table)
            {
                for (int i = 0; i < table.Length; i++)
                    if (symbol == table[i])
                        return true;
                return false;
            }

        }
    }
}

    //using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Если хотите узнать век Введите Год ");
//        int year = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"{(year - 1) / 100 + 1} Век ");
//        Console.ReadKey();
//    }
//}


//using System;


//namespace lol
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            

//            Console.WriteLine("Привет");
//            Method1();
//            string s = Method2();
//            Console.WriteLine(s);


//        }
//        static void Method1()
//        {
//            int a = 5;
//            int b = 6;
//            if (a > b)
//            {
//                Console.WriteLine("пока");
//            }
//            else
//            {
//                Console.WriteLine(b);
//            }
//        }

//        static string Method2()
//        {
//            return "lkfokdvfd";
//        }



//    }
//}





//using System;
//namespace Progrsm
//{


//    public static class Program
//    {

//        public static void Main()

//        {






//            int[] num = new int[4] { 12, 56, 89, 118 };
//             int sum = 0;
//             int medium;
//            const int myValue = 65;
//            for (int i = 0; i < num.Length; i++)
//            {
//                sum += num[i];
//            }

//            medium = sum / num.Length;
//            Console.WriteLine(medium);
//            bool www = Func( medium,  myValue);
//            Console.WriteLine(www);

//        }
//        static bool Func(int medium, int myValue)
//        {


//            if (medium > myValue)
//            {
//                return false;
//            }
//            else
//            {
//                return true;
//            }

//        }
//}

//}




//namespace Program
//{


//    public static class Program
//    {

//        public static void Main()

//        {
//            string result = "";
//            for (int i = 1; i <= 8; i++)
//            {
//                result += $"{i} sheep...";
//            }
//            Console.WriteLine ( result);

//double[] array = new double[5] { 15, 16.0, 17, 18, 19 };
//double sum = 0;
//double medum;
//for (int i = 0; i < array.Length; i++)
//sum = sum + array[5];
//medum = sum / array.Length;
//Console.WriteLine(medum);

//int h = 0;
//int m = 0;
//int s = 1;
//h *= 3600000;
//m *= 60000;
//s *= 1000;
//Console.WriteLine(h + m + s);

//int[] array;
//array = new int[9];
//for (int i = 0;i < array.Length; i ++)

//if (array[i] % 2 == 0)
//{
//        

//}

//using System;
//using System.Diagnostics.CodeAnalysis;
//using System.Linq;

//namespace Progrsm
//{


    //public static class Program
    //{

    //    public static void Main()

    //    {
    //        //int[] array = { 254, 9, 45, 78, 69, 24, 35 };

    //        //int result = array.Max();
    //        //int qwer = array.Min();
    //        //int pir = result + qwer;




    //        //Console.WriteLine(pir);
    //        int n = int.Parse (Console.ReadLine());
    //        int sum = 0;
    //        for (int i = 0; i <=n; i++)
    //        {
    //            if (i % 5 == 0 || i % 3 == 0)
    //            {
    //                sum += i;
    //            }
    //        }
    //        Console.WriteLine(sum);
            
        
    //    }    
    //}




 
namespace kvadrat
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Ведите число: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("{0} в квадрате {1}", a, Math.Pow(a, 2));
            //Console.ReadLine();

            //int n = 1234;
            //string output = "";
            //foreach (char c in n.ToString())
            //{
            //    int square = int.Parse(c.ToString());
            //    output += (square * square);
            //}
            //Console.WriteLine(int.Parse(output));

            //int[] a = new int[5] { 120, 50, 80, 35, 87 };

            //int result1 = 0;
            //int result2 = 0;
            //int len = a.Length;
            //if (len == 0)
            //{
            //    Console.WriteLine( new int[] { 0, 0 });
            //}
            //for (int i = 0; i < len; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        result1 += a[i];
            //    }
            //    else
            //    {
            //        result2 += a[i];
            //    }
            //}
            //Console.WriteLine ( new int[] { result1, result2 });

            //    string e = Repeater();
            //       Console.WriteLine(e);
            //        }





            //public static string Repeater()
            //{


            //    string s = " LXV";
            //    int n = 100;

            //    var result = "";
            //    string d = "                        ";
            //    for (int i = 0; i < n; i++)
            //    {
            //        result += s;
            //        result += d;

            //    }

            //    return result;



            //if (d < 0) return null;
            //int r = 0;
            //for (double a = 0.0001; a < d; a *= 2, r++) ;
            //Console.WriteLine(r);





        }
    }
}


