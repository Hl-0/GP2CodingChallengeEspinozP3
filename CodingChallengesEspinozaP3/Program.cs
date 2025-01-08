// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Challenges
{

    public static void Main(string[] args)
    {
        var keepLoop = true;
        while (keepLoop)
        {
            Console.WriteLine("Welcome again to my coding Challenge program plase select any of the 20 numbers");
            var progarmchoose = Console.ReadLine();
            int progarmchooseint = int.Parse(progarmchoose);

            if (progarmchooseint == 1)
            {
                Console.WriteLine("Welcome to my coding challenge program. There will be a variety of different funtions you will have to choose from. Please select one");

                Console.WriteLine("Today we are going to use the number adder called SUM. Please input two numbers for us to add. \n");

                var number1 = Console.ReadLine();
                int number1int = int.Parse(number1);

                Console.WriteLine("Awesome! Please input a second number");

                var number2 = Console.ReadLine();
                int number2int = int.Parse(number2);


                Console.WriteLine("The sum of the number: " + number1int + " and the number: " + number2int + " is equal to: " + Sum(number1int, number2int));
                Sum(number1int, number2int);
            }
            //minutes to seconds
            if (progarmchooseint == 2)
            {
                Console.WriteLine("This Programs is to convert minutes to seconds");
                Console.WriteLine("Let's try converting minutes into seconds. \n Give me a number to convert from minutes to seconds");

                var number3 = Console.ReadLine();
                int number3int = int.Parse(number3);
                Console.WriteLine(number3int + " Minutes converted to seconds: " + Convertion(number3int) + " amount of seconds");
            }
            //Increments the number by +1
            if (progarmchooseint == 3)
            {
                Console.WriteLine("This Programs is to increments the number by +1");
                Console.WriteLine(" Let's start by putting one number the the system will add 1 to it.\n");

                var number4 = Console.ReadLine();
                int number4int = int.Parse(number4);

                Console.WriteLine(Increments(number4int));
            }
            //Mutliply the number
            if (progarmchooseint == 4)
            {
                Console.WriteLine("This Program is to calculate power into voltage and current");
                Console.WriteLine("Let start by add two numbers.\n");

                var number5 = Console.ReadLine();
                int number5int = int.Parse(number5);
                var number6 = Console.ReadLine();
                int number6int = int.Parse(number6);
                Console.WriteLine(mutliply(number5int, number6int));
            }
            //birthday into days
            if (progarmchooseint == 5)
            {
                Console.WriteLine("How old are you do you want to know how manayy days you are old");

                var number7 = Console.ReadLine();
                int number7int = int.Parse(number7);
                Console.WriteLine(Years(number7int));
            }
            //divison
            if (progarmchooseint == 6)
            {
                Console.WriteLine("We are going to divide base and height the is going to be divide by 2");
                var number8 = Console.ReadLine();
                int number8int = int.Parse(number8);
                var number9 = Console.ReadLine();
                int number9int = int.Parse(number9);
                Console.WriteLine(division(number8int, number9int));
            }
            //lessThanOrEqualToZero
            if (progarmchooseint == 7)
            {
                Console.WriteLine("We are going to deterime what is less than or equal to zero is true and any other number would be false");
                var number10 = Console.ReadLine();
                int number10int = int.Parse(number10);
                Console.WriteLine(lessThanOrEqualToZero(number10int));
            }
            if (progarmchooseint == 8)
            {
                Console.WriteLine("give me two number and in return i will add them up and depening that it will return false \nif over 100 and true if any are lower than 100");
                var number11 = Console.ReadLine();
                int number11int = int.Parse(number11);

                var number12 = Console.ReadLine();
                int number12int = int.Parse(number12);

                Console.WriteLine(LessThan100(number11int, number12int));
            }
            if (progarmchooseint == 9)
            {
                Console.WriteLine(" give me two numbers and it they are not equal then it would be false, then if it is equal then it is true");
                var number13 = Console.ReadLine();
                int number13int = int.Parse(number13);

                var number14 = Console.ReadLine();
                int number14int = int.Parse(number14);

                Console.WriteLine(equaltoo(number13int, number14int));

            }
            if (progarmchooseint == 10)
            {
                Console.WriteLine(" Give me some words and with that the word SOMETHING \nis going to be add to it in the sentence.");
                var words = Console.ReadLine();

                Console.WriteLine(GiveMeSomething(words));
            }
            if (progarmchooseint == 11)
            {
                Console.WriteLine("Give me the worsd either true or false and it will be revesed");
                var trueorfalse = Console.ReadLine();
                if (trueorfalse == "true")
                {
                    Console.WriteLine("To bad it is false :I");
                }
                else if (trueorfalse == "false")
                {
                    Console.WriteLine("To bad it is True :I");
                }
                else
                {
                    Console.WriteLine("Maybe you misspelled it or didn't give me the option please select again");
                }
            }
            if (progarmchooseint == 12)
            {
                Console.WriteLine("Give me value that will be in hours and that will convert into seconds");
                var number15 = Console.ReadLine();
                int number15int = int.Parse(number15);

                Console.WriteLine(HoursintoSeconds(number15int));
            }
            if (progarmchooseint == 13)
            {
                Console.WriteLine("Give me a number and it will give you the n-sided regular polygon.\nDon't give me 2 due to that anything below is zero.");
                var number16 = Console.ReadLine();
                int number16int = int.Parse(number16);
                if (number16int <= 2)
                {
                    Console.WriteLine("try to input a higher number than two please try again");
                }
                else
                {
                    Console.WriteLine(SumOfPolygon(number16int));
                }
            }
            if (progarmchooseint == 14)
            {
                Console.WriteLine("Give me a word and Edabit \nis going to be add at the end of it");
                var number17 = Console.ReadLine();
                Console.WriteLine(Edabit(number17));

            }
            if (progarmchooseint == 15)
            {
                Console.WriteLine("give me a value that is going to be true and false");
                var a = Console.ReadLine();
                bool abool = bool.Parse(a);
                Console.WriteLine("give me a value that is going to be true and false");
                var b = Console.ReadLine();
                bool bbool = bool.Parse(b);
                Console.WriteLine("And(" + a + "," + b + ")-->" + TOrF(abool, bbool));

            }
            if (progarmchooseint == 16)
            {
                Console.WriteLine("Give me two number and it will be the 2 pointers and 3 pointers");
                var number18 = Console.ReadLine();
                int number18int = int.Parse(number18);
                Console.WriteLine("Alright this number will be 3 pointer counter");
                var number19 = Console.ReadLine();
                int number19int = int.Parse(number19);
                Console.WriteLine("Points(" + number18 + "," + number19 + ")-->" + BasketBall(number18int, number19int));

            }
            if (progarmchooseint == 17)
            {
                Console.WriteLine("Give me the lenght of an object and the width of the object");
                var number20 = Console.ReadLine();
                int number20int = int.Parse(number20);
                var number21 = Console.ReadLine();
                int number21int = int.Parse(number21);
                Console.WriteLine("FindPreimeter(" + number20 + "," + number21 + ")-->" + FP(number20int, number21int));
            }
            if (progarmchooseint == 18)
            {
                Console.WriteLine("Give me a word and hello will be added in the begining of  the scenetnce");
                var words = Console.ReadLine();

                Console.WriteLine(hello(words) + "!");

            }
            if (progarmchooseint == 19)
            {
                Console.WriteLine("In this challenge, a farmer is asking you to tell him how many legs can be counted among all his animals.\n The farmer breeds three species");
                var number22 = Console.ReadLine();
                float number22int = float.Parse(number22);
                var number23 = Console.ReadLine();
                float number23int = float.Parse(number23);
                var number24 = Console.ReadLine();
                float number24int = float.Parse(number24);
                Console.WriteLine("Animals(" + number22 + "," + number23 + "," + number24 + ")-->" + Farm(number22int, number23int, number24int));
            }
            if (progarmchooseint == 20)
            {
                Console.WriteLine("takes the number of wins, draws and losses and calculates the number of points a football team has obtained so far.\n Call the function and print the results");
                var number25 = Console.ReadLine();
                float number25int = int.Parse(number25);
                var number26 = Console.ReadLine();
                float number26int = int.Parse(number26);
                var number27 = Console.ReadLine();
                float number27int = int.Parse(number27);
                Console.WriteLine("FootballPoints(" + number25 + "," + number26 + "," + number27 + ")-->" + score(number25int, number26int, number27int));
            }
            if (progarmchooseint == 21)
            {
                Console.WriteLine("");
                var number28 = Console.ReadLine();
                int number28int = int.Parse(number28);
                if (number28int == 1)
                {
                    Console.WriteLine("month name(1)--> January");
                }
                if (number28int == 2)
                {
                    Console.WriteLine("month name(2)--> Febuary");
                }
                if (number28int == 3)
                {
                    Console.WriteLine("month name(3)--> March");
                }
                if (number28int == 4)
                {
                    Console.WriteLine("month name(4)--> April");
                }
                if (number28int == 5)
                {
                    Console.WriteLine("month name(5)--> May");
                }
                if (number28int == 6)
                {
                    Console.WriteLine("month name(6)--> June");
                }
                if (number28int == 7)
                {
                    Console.WriteLine("month name(7)--> July");
                }
                if (number28int == 8)
                {
                    Console.WriteLine("month name(8)--> August");
                }
                if (number28int == 9)
                {
                    Console.WriteLine("month name(9)--> September");
                }
                if (number28int == 10)
                {
                    Console.WriteLine("month name(10)--> October");
                }
                if (number28int == 11)
                {
                    Console.WriteLine("month name(11)--> November");
                }
                if (number28int == 12)
                {
                    Console.WriteLine("month name(12)--> December");
                }
                
            }
            if (progarmchooseint == 22)
            {
               
                int[] arr1 = new int[5];
                int max, min;
                Console.WriteLine("Enter Array Element");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Element {0} - ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }
                    max = arr1[0];
                    min = arr1[0];
                
                    for (int i=0; i<arr1.Length;i++)
                    {
                        if (arr1[i] > max)
                        {
                            max = arr1[i];
                        }
                        if(arr1[i] < min)
                        {
                            min = arr1[i];
                        }
                    }
                    Console.WriteLine(" Maximun number form an arry is {0}", max);
                    Console.WriteLine("Minimun number from an array is {0}", min);
                
            }
            else
            {
                Console.WriteLine("Maybe you misspelled it or didn't give me the options that is given please select.");
                Console.WriteLine("------This number is invaled plase select again.-------");
            }
        }
    }

        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
        public static int Convertion(int number3)
        {
            return number3 * 60;
        }
        public static int Increments(int number4)
        {
            return number4 + 1;
        }
        public static int mutliply(int number5, int number6)
        {
            return (number5 * number6);
        }
        public static int Years(int number7)
        {
            return (number7 * 365);
        }
        public static float division(float number8, int number9)
        {
            return (number8 * number9) / 2;
        }
        public static bool lessThanOrEqualToZero(int number10)
        {
            if (number10 <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool LessThan100(int number11, int number12)
        {
            if (number11 + number12 <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool equaltoo(int number13, int number14)
        {
            if (number13 == number14)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string GiveMeSomething(string words)
        {
            var Smthn = " Something ";
            return Smthn + words;
        }
        public static int HoursintoSeconds(int number15)
        {
            return (number15 * 60 * 60);
        }
        public static float SumOfPolygon(float number16)
        {
            return (number16 - 2) * 180;
        }
        public static string Edabit(string number17)
        {
            var bit = "Edabit";
            return number17 + bit;
        }
        public static bool TOrF(bool a, bool b)
        {
            if (a == true && b == true)
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }
        public static int BasketBall(int number18, int number19)
        {
            return (number18 * 2 + number19 * 3);
        }
        public static int FP(int number20, int number21)
        {
            return (number20 * 2 + number21 * 2);
        }
        public static string hello(string words)
        {
            var helo = " Hello ";
            return helo + words;
        }
        public static float Farm(float number22, float number23, float number24)
        {
            return (number22 * 2 + number23 * 4 + number24 * 4);
        }
        public static float score(float number25, float number26, float number27)
        {
            return (number25 * 3 + number26 * 1 + number27 * 0);
        }


    
}
