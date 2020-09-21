using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2Array
{
    class Program
    {
        static void fiilrand(int[] arr, int left = -10, int rigth = 20)
        {

            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(left, rigth + 1);

            }
        }
        static void print(int[] arr, string title = "")
        {
            Console.WriteLine($"{title}");
            foreach (int i in arr)
            {
                Console.Write($"\n {i,5} \t");
            }
            Console.WriteLine();
        }



       
     //- метод повертає кількість парних  елементів масиву(використати Count() з  System.Linq)
     
        static void swapElementArray(int [] arr,int index1,int index2)
        {
                int tmp = arr[index1];
                arr[index1] = arr[index2];
                arr[index2] = tmp;
            
        }
        static void findIndexDivisionOfSeven(int[] arr)
        {
            int index = Array.FindIndex(arr, (int x) => x % 7 == 0);
            Console.WriteLine($" Number {arr[index]} with  index : {index}");
        }
        static void findPositiveNumber(int[] arr)
        {
            int index = Array.FindIndex(arr, (int x) => { return x > 0; });
            Console.WriteLine($" Number {arr[index]} > 0 with  index : {index}");
        }
        static void Task1()
        {
            int[] arr = new int[10];//1
            fiilrand(arr);//2
            print(arr);//3
            swapElementArray(arr, 0, 9);//4
            print(arr);
            findPositiveNumber(arr);//5

            findIndexDivisionOfSeven(arr);//7
           

        }

        static void Task2()
        {
            int[] arr = new int[10] { 10, 0, 9, 87, 0, 6, 7, 0, 9, 7 };
            int tmp = 0;
            print(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    tmp++;
                }
                else
                {
                  arr[i - tmp] = arr[i];
                }
                    
            }
            for (int i = arr.Length - tmp; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
            print(arr);
        }

        static void Task7()
        {
            int[] arrayPrice = new int[10] { 100, 9, 55, 43, 50, 23, 21, 89, 10, 5 };
            string[] arrayProduct = new string[10] { "Apple","Orange","Strawbarry","Bluberry","Banana","Sweets","Cake","Milk","Coffe","Tea"};


           
            for (int i = 0; i < arrayProduct.Length; i++)
            {
                Console.Write($"\n {arrayProduct[i],10} \t");
            }

            Array.Sort(arrayPrice,(x,y)=>x.CompareTo(y));
            for (int j = 0; j < arrayPrice.Length; j++)
            {
                Console.Write($"\n {arrayPrice[j],20}\t");
            }




        }
        static void Task5()
        {
            int[] arr = { 4, 6, 74, 746, 8, 2, 1, 10 };

            int Max = arr.Max();
            int Min = arr.Min();
            int posMin = Array.IndexOf(arr, Min);
            int posMax = Array.IndexOf(arr, Max);
            Console.WriteLine(posMax);
            Console.WriteLine(posMin);
            int sum = 0;
            for (int i = posMax; i < posMin; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
        static void Task3()
        {
            int[] arr = { -1, -5, 7, -6, 89, 6, -7 };
            int[] neg = Array.FindAll(arr, (x) => x < 0);
            int[] pos = Array.FindAll(arr, (x) => x > 0);
            neg.CopyTo(arr, 0);
            pos.CopyTo(arr, neg.Length);
            print(neg);
            print(pos);

        }
        static void Task4()
        {
            int[] arr=new int[10];
            fiilrand(arr);
            print(arr);
                int read = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Count  number {read}  arr : {arr.Count(x => x == read)}");


            
        }



        static void Task6()
        {

            int[] arr = new int[10];
            fiilrand(arr);
            print(arr);
            int[] arrSum = Array.FindAll(arr, (x) => x % 2 == 0);
            int pairSum = 0;
            for (int i = 0; i < arrSum.Length; i++)
            {
                pairSum += arrSum[i];
            }
            Console.WriteLine($"Sum pair={pairSum}");

        }

        static void Main(string[] args)
        {
            Task6();
            //Task1();
            //Task2();
            //Task3();
           // Task4();
            //Task5();

            //Task7();
            
            
        }
    }
}
