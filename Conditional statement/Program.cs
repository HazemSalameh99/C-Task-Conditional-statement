using System;

namespace Conditional_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Task 2.1
            //int num1, num2;
            //int smallernum;
            //Console.Write("Enter the first integer: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the second integer: ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //if (num1 < num2)
            //    smallernum = num1;
            //else smallernum = num2;
            //Console.WriteLine("The smaller number is: " + smallernum);


            ////Task 2.2
            //Console.WriteLine("Enter a Number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number < 0)
            //    Console.WriteLine("The sign is -");
            //else if (number > 0)
            //    Console.WriteLine("The sign is +");
            //else
            //    Console.WriteLine("The Number is Zero,and its sign is neutral.");


            ////Task 2.3
            //Console.WriteLine("Enter The first Number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter The second  Number");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter The third Number");
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //if (num1 < num2)
            //{
            //    num1 = num1 + num2;
            //    num2 = num1 - num2;
            //    num1 = num1 - num2;
            //}
            //if(num2<num3)
            //{
            //    num2 = num2 + num3;
            //    num3 = num2 - num3;
            //    num2 = num2 - num3;
            //}
            //if(num1<num2)
            //{
            //    num1 = num1 + num2;
            //    num2 = num1 - num2;
            //    num1 = num1 - num2;
            //}
            //Console.WriteLine($"Sorted numbers in ascending order: {num1}, {num2}, {num3}");


            ////Task 2.4
            //int[] numberArr = new int[5];
            //int max = 0;
            //for(int i=0;i< numberArr.Length;i++)
            //{
            //    Console.WriteLine($"Enter The Element of numberArr[{i}]:");
            //    numberArr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for(int i = 1; i < numberArr.Length; i++)
            //{
            //    if (numberArr[max]<numberArr[i])
            //    {
            //        numberArr[max] = numberArr[i];
            //    }
            //}
            //Console.WriteLine("---------------");
            //Console.WriteLine("The maximum number is: "+numberArr[max]);


            ////Task 2.5
            //Console.WriteLine("Input kilometers per hour: ");
            //double kilometersPerHour = Convert.ToDouble(Console.ReadLine());
            //double milesPerHour = kilometersPerHour * 0.621371;
            //Console.WriteLine($"{kilometersPerHour} kilometers per hour is equal to {milesPerHour} miles per hour");



            ////Task 2.6
            //Console.Write("Input Hours: ");
            //int hour = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Minutes: ");
            //int minute = Convert.ToInt32(Console.ReadLine());
            //int totalNumberOfMinutes = (hour * 60) + minute;
            //Console.WriteLine($"Total: {totalNumberOfMinutes} minutes");




            ////Task 2.7
            //Console.Write("Input Minutes: ");
            //int totalMinute = Convert.ToInt32(Console.ReadLine());
            //int hour = totalMinute / 60;
            //int minute = totalMinute % 60;
            //Console.WriteLine($"{hour} Hours, {minute} Minutes.");



            //    //Task 2.8
            //    string[] sentences = {
            //    "Hazem Salameh",
            //    "Hazem Kamal Salameh",
            //    "Hazem Kamal Mohammad Salameh",
            //    "Hazem Kamal Mohammad Salameh I,m Full Stack Developer",
            //    "Hazem Kamal Mohammad Salameh I,m Full Stack Developer, Asp.Net Developer"
            //};
            //    int fixedLength = 30;
            //    foreach (string sentence in sentences)
            //    {
            //        Console.WriteLine(sentence.PadRight(fixedLength));
            //    }



            //Task 2.9

            Console.Write("Enter The String:");
            string text = Console.ReadLine();
            Console.WriteLine(reverseOdd(text));
            static string reverseOdd(string input)
            {
                string[] words = input.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length % 2 != 0)
                    {
                        char[] charArray = words[i].ToCharArray();
                        Array.Reverse(charArray);
                        words[i] = new string(charArray);
                    }
                }

                return string.Join(" ", words);
            }




        }
    }
}
