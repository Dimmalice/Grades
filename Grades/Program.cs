using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Speech.Synthesis; 
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook(); //me to new orizw ena neo kommati ths klasis GradeBook sthn periptwsh mas to book. H parenthesi simainei pws einai method//



            //GetBookName(book);

            AddGrades(book);

            SaveGrades(book);

           WriteResults(book);

        }

       
        private static IGradeTracker CreateGradeBook()
        {

          

            return new ThrowAwayGradeBook();
        }

        private static void WriteResults(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();

            foreach (float grade in book)
            {
                Console.WriteLine(grade);
            }

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        private static void SaveGrades(IGradeTracker book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))//to using einai gia close method
            {
                book.WriteGrades(outputFile);

            }
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName(IGradeTracker book)
        {
            try
            {
                Console.WriteLine("Enter a name...");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        //static void WriteResult(string description, int result) //edw leme vgale result oson afora ta int
        //{
        //    Console.WriteLine(description + ": " + result);
        //}



        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void WriteResult (string description, float result) 
        {
            Console.WriteLine($"{description}: {result:F2}");// edw afora ta float me th diafora pws orizoume me to $ to prwto element kai sto 2o leme kado float me dio dekadika
        }
    }
}
