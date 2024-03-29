﻿using System;
using System.Text.RegularExpressions;

namespace Week1Task
{
    public class UserInput
    {
        public int CourseUnit { get; set; }
        public int CourseScore { get; set; }
        public string CourseCode { get; set; }

       

        public string AddCourseCode()
        {
            Console.Write("     Input Course Code: ");
            CourseCode = Console.ReadLine();

            string pattern = "^[A-Z]{3}[0-9]{3}$";
            bool match = Regex.IsMatch(CourseCode, pattern);

            if (match == false )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("     Invalid Course Code.  Course Code should consist of 3 uppercase alphabets and 3 digits with no space between them.");
                Console.ResetColor();
                AddCourseCode();
            }
            return CourseCode;
        }


        public int AddCourseUnit()
        {
            Console.Write("     Input Course Unit: ");
            try
            {
                CourseUnit = int.Parse(Console.ReadLine());
                while (CourseUnit < 1 || CourseUnit > 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("     Invalid Course unit.  Course Unit should be a number between 1 and 9.");
                    Console.ResetColor();
                    AddCourseUnit();
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("     Invalid Course unit.  Course Unit should be a number between 1 and 9.");
                Console.ResetColor();
                AddCourseUnit();
            }
            return CourseUnit;
        }

        public int AddCourseScore()
        {
            Console.Write("     Input Course Score: ");
            try
            {
                CourseScore = int.Parse(Console.ReadLine());
                while (CourseScore < 0 || CourseScore > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("     Invalid Course score.  Course score should be a number between 0 and 100.");
                    Console.ResetColor();
                    AddCourseScore();
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("     Invalid Course score.  Course score should be a number between 0 and 100.");
                Console.ResetColor();
                AddCourseScore();
            }
            return CourseScore;
        }
    }
}
