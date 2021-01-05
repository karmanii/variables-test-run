using System;

namespace Variables2
{
    class Program
    {
        static void Main(string[] args)

        {  
            string Name = "";
            string sex = "";
            string zodiacSign = "";
            int age = 0;
            double height = 0;
            int level = 0;
            double firstSemesterGP = 0;
            double secondSemesterGP = 0;
            double result = 0;

            Console.WriteLine("This is your Personal Bio Data, kindly fill in details correctly");
            Console.WriteLine();

            Console.Write("Please enter your name: ");
            Name = Console.ReadLine();

            Console.Write("Please enter sex: ");
            sex = Console.ReadLine();

            Console.Write("Please enter zodiac sign: ");
            zodiacSign = Console.ReadLine();

            Console.Write("Please enter age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("please enter height: ");
            height = double.Parse(Console.ReadLine());

            Console.Write("Please enter level: ");
            level = int.Parse(Console.ReadLine());
        
            Console.Write("Please enter first semester GP: ");
            firstSemesterGP = double.Parse(Console.ReadLine());

            Console.Write("Please enter second Semester GP: ");
            secondSemesterGP = double.Parse(Console.ReadLine());

            result = (firstSemesterGP + secondSemesterGP) / 2.0;
            Console.WriteLine("Your CGPA is " + result);
        }
    }
}
