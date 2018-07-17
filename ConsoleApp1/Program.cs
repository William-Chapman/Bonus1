using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int inputNum;

            Console.WriteLine("Welcome to the Letter Grade Converter!");
            //get user input
            Console.Write("Enter the numerical grade: ");
            inputNum = int.Parse(Console.ReadLine());

            string alphaGrade;
            //get alphabetical grade by checking what range the provided numerical grade is between
            if (inputNum >= 99)
            {
                alphaGrade = "A+";
            }
            else if (inputNum > 89 && inputNum < 99)
            {
                alphaGrade = "A";
            }
            else if (inputNum > 87 && inputNum < 89)
            {
                alphaGrade = "A-";
            }
            else if (inputNum > 85 && inputNum < 88)
            {
                alphaGrade = "B+";
            }
            else if (inputNum < 86 && inputNum > 81)
            {
                alphaGrade = "B";
            }
            else if (inputNum < 82 && inputNum > 79)
            {
                alphaGrade = "B-";
            }
            else if (inputNum < 80 && inputNum > 77)
            {
                alphaGrade = "C+";
            }
            else if (inputNum < 78 && inputNum > 67)
            {
                alphaGrade = "C";
            }
            else if (inputNum < 69 && inputNum > 66)
            {
                alphaGrade = "C-";
            }
            else if (inputNum < 67 && inputNum > 64)
            {
                alphaGrade = "D+";
            }
            else if (inputNum < 65 && inputNum > 62)
            {
                alphaGrade = "D";
            }
            else if (inputNum < 60 && inputNum > 63)
            {
                alphaGrade = "D-";
            }
            else
            {
                alphaGrade = "F";
            }

            //output the letter and number grade
            Console.WriteLine($"Letter Grade: {alphaGrade}");

            //continue
            Continue();
        }

        static void Continue()
        {
            Console.WriteLine("Continue? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
            {
                //if yes, restart at main
                Main();
            }
            else
            {
                //if no, exit
                return;
            }
        }
    }
}
