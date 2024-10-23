// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;
class Challenges
{

    public static void Main(string[] args)
    {
        var keepLoop = true;
        while (keepLoop)
        {
            Console.WriteLine("Welcome again to my coding Challenge program plase select any of the 8 numebers");
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
            if (progarmchooseint ==2)
            {
                Console.WriteLine("This Programs is to convert minutes to seconds");
                Console.WriteLine("Let's try converting minutes into seconds. \n Give me a number to convert from minutes to seconds");

                var number3 = Console.ReadLine();
                int number3int = int.Parse(number3);
                Console.WriteLine(number3int + " Minutes converted to seconds: " + Convert(number3int) + " amount of seconds");
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
            if(progarmchooseint ==8)
            {
                Console.WriteLine("give me two number and in return i will add them up and depening that it will return false \nif over 100 and true if any are lower than 100");
                var number11 = Console.ReadLine();
                int number11int = int.Parse(number11);

                var number12 = Console.ReadLine();
                int number12int = int.Parse(number12);

                Console.WriteLine(LessThan100(number11int, number12int));
            }
            else
            {
                Console.WriteLine("------This number is invaled plase select again.-------");
            }
        }
    }
    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }
    public static int Convert(int number3)
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
        if(number10 <= 0)
        {
        return true;
        }
        return false;
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
}
