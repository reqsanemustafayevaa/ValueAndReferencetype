using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int a = 5;
            // int b = 6;
            //int a = 7;
            //// Console.WriteLine(a + b);
            // ChangeNumber(a);
            // Console.WriteLine(a);
            //MakeNumberHundred(ref a);
            //int[] numbers = new int[5] {1,2,3,4,5};
            //ResizeArray(ref numbers, 100);
            //ResizeArray(ref numbers, 89);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //int eded=int.Parse(Console.ReadLine());
            //Console.WriteLine("Number=" + eded);
            //Console.WriteLine("Bir eded daxil edin:");

            //CheckValue(Console.ReadLine());
            #region 2 array yaradin 1 ci arrayde Rasim adini deyisende 2 cidede deyissin
            //string[] arr1 = { "Yusif", "Enver", "Zohrab", "Ramzes" };
            ////string[] arr2 = { "Elsever", "Hamdi", "Maga", "Aziz" };
            //string[] arr2 = arr1;
            //arr1= arr2;
            //arr1[0] = "Raghsana";
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}
            //for (int i = 0;i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}
            #endregion
            Console.WriteLine("Bir eded daxil edin:");
            int eded=Convert.ToInt32(Console.ReadLine());
            int result = positivenumber(eded);
            Console.WriteLine("result: "+ result);
            



        }
        static void ResizeArray(ref int[] numbers,int num)
        {
            int[] newArray = new int[numbers.Length+1]; //0 0 0 0 0 0
            for(int i = 0; i < numbers.Length; i++)
            {
                newArray[i] = numbers[i]; //1 2 3 4 5 
               
            }
            newArray[newArray.Length-1] = num; 
       
            numbers = newArray;


        }
        static void ChangeNumber(int number)
        {
            number = 100;
         
        }
        static void MakeNumberHundred(ref int number)
        {
            number = 100;
            Console.WriteLine(number);
        }
        static void CheckValue(string value)
        {
            if(int.TryParse(value,out int result))
            {
                Console.WriteLine($"{result} numberdir");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        static int positivenumber(int num)
        {
            if(num<0)
            {
                num *= -1;
            }
           return num+100;
        }

    }
}
