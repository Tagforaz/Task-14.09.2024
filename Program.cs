using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Task_14._09._2024
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Task1
            //int count;
            //Console.WriteLine("Bir reqem qeyd edin:");
            //count = int.Parse(Console.ReadLine()); // string den int e cevirmek ucun 
            //Square(count);

            //Task2
            //squareArray(3, 4, 5);

            //Task3
            //string fullName ;
            //Console.WriteLine("Zehmet olmasa, Ad ve Soyad qeyd edin:");
            //fullName = Console.ReadLine();
            //FullName(fullName);
            ////Alternativ
            //string word = "Hikmet Abbasov";
            //ChangeStr(ref word);
            //Console.WriteLine(word);
            //static void ChangeStr(ref string str)
            //{
            //    string newStr = "";
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //      if(str[i] != ' ')
            //        {
            //            newStr += str[i];
            //        }     
            //    }
            //    str = newStr;
            //}

            //Task4
            //int num = 60;
            //int[] nums = { 1, 2, 3, 4, 5, };
            //ArrayLength(num, nums);
            ////Alternativ
            int[] numbers = { 3, 7, 1 };
            AddArr(ref numbers, 9);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            #region Optional Task1
            //int num = 12;

            //if (num%3==0 && num%7==0)
            //{
            //    Console.WriteLine("Eded 3 ve 7 ye bolunur");

            //}
            //else
            //{
            //    Console.WriteLine("Eded 3 ve 7ye bolunmur");
            //}
            #endregion
            #region Optional Task2
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int count = 0;

            //for (int i = 0; i < nums.Length; i++)

            //{

            //    if (nums[i] % 2 != 0)
            //    {
            //        count++;

            //    }
            //}
            //Console.WriteLine($"Tek ededlerin sayi {count}");
            #endregion
            #region Optional Task3
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum = 0;


            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 != 0)
            //    {
            //        sum += nums[i];
            //    }
            //}
            //Console.WriteLine($"Tek ededlerin cemi:{sum}");
            #endregion
            #region Optional Task4
            //int num = 20;
            //if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0)
            //{
            //    Console.WriteLine("Eded murekkebdir");
            //}
            //else
            //{
            //    Console.WriteLine("Eded sadedir");
            //}
            #endregion
            #region Optional Task5
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        sum += nums[i];
            //    }
            //}
            //Console.WriteLine($"Cut ededlerin cemi {sum} ");
            #endregion
            #region Task1
            //static void Square(int count)

            //{
            //    Console.WriteLine($"Cavab: {count * count}");
            //}
            #endregion
            #region Task2    
            //static void squareArray(params int[] array)
            //{
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.WriteLine(array[i] * array[i]);
            //    }


            //}
            #endregion
            #region Task3

            //static void FullName(string fullName)
            //{
            //    string bosluq = "";
            //    for (int i = 0; i < fullName.Length; i++)
            //    {
            //        if (fullName[i] != ' ')
            //        {
            //            bosluq += fullName[i];
            //        }

            //    }

            //    Console.WriteLine($"Netice:{bosluq}");


            //}



            #endregion
            #region Task4

            //static void ArrayLength(int num, int[] nums)
            //{
            //    int[] newNums = new int[nums.Length + 1];

            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        newNums[i] = nums[i];
            //    }

            //    newNums[nums.Length] = num;

            //    Console.WriteLine("Artirilmis massiv:");

            //    for (int i = 0; i < newNums.Length; i++)
            //    {
            //        Console.WriteLine(newNums[i]);
            //    }
            //}

            ////Alternativ
            static void AddArr(ref int[] array,int num)
            {
                int[] newArr = new int[array.Length+1];
                for (int i = 0; i < array.Length; i++)
                {
                    newArr[i] = array[i];
                }
                newArr[array.Length] = num;
                array = newArr;
            }
            
            #endregion

        }
    }
}


