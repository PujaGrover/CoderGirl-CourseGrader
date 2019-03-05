using System;
//C:\Users\Puja\Source\Repos\PujaGrover\CoderGirl-CourseGrader\CourseGrader\Program.cs
namespace CourseGrader
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a method named GradeTestScores that takes an array of test scores as its parameter and returns a string
            // GradeTestScores will add up these test scores and calculate an average score. 
            // It should then return a message of "pass" or "fail" depending on these two conditions:
            // If the average score is greater than or equal to 70 and no single test score is below 50, then return a message of "pass".
            // If the average score is lower than 70 or at least one test score is below 50, then return a message of "fail".

            int [] testScores = new int[] {70, 70, 55, 70, 70, 70};
            Console.WriteLine(GradeTestScores(testScores));
            Console.ReadLine();
        }

        public static string GradeTestScores(int[] testScores)
        {
            int sum = 0;

            if (testScores.Length < 1)
            return "fail";

            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] < 50)
                { 
                    //Console.WriteLine(testScores[i]);
                    return "fail";                   
                }
                else
                { 
                sum += testScores[i];
                //Console.WriteLine(sum);
                }
            }

            int averageScore = sum / testScores.Length;
            //Console.WriteLine(sum);
            //Console.WriteLine(averageScore);
            if (averageScore < 70)
            {
                return "fail";
            }
            else
            {
                return "pass";
            }
        }
    }
}   

