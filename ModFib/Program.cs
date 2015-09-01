//using System;
//using System.Collections;
//using System.Numerics;

//namespace ModFib
//{
//    class Program
//    {
//        static int _a;
//        static int _b;
//        static void Main(String[] args)
//        {
//            string str = Console.ReadLine();
//            string[] strArray = str.Split(' ');
//            //strArray[3] -= 2;
//            _a = Int32.Parse(strArray[0]);
//            _b = Int32.Parse(strArray[1]);
//            int n = Int32.Parse(strArray[2]);
//            Console.WriteLine(modfib(n));

//        }

//        static BigInteger modfib(int counter)
//        {
//            ArrayList data = new ArrayList();
//            data[0] = _a;
//            data[1] = _b;
//            for (int i = 2; i < counter; i++)
//            {
//                data[i] = data[i - 1] * data[i - 1] + data[i - 2];
//            }
//            return data[counter - 1];
//        }
//    }
//}
