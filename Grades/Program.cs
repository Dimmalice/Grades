using System;
using System.Collections.Generic;
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

            //SpeechSynthesizer synth = new SpeechSynthesizer(); // to ekana add me deksi click sto references kai browse apo to Library. leei oti tou orisoume sthn grammi apo katw
           // synth.Speak("hello hello");



            GradeBook book = new GradeBook(); //me to new orizw ena neo kommati ths klasis GradeBook sthn periptwsh mas to book. H parenthesi simainei pws einai method//
            book.Name = "Grade Book";
            book.Name = null; // dokimi wste na doume pws me to property pou orisame den borei na alaksei to onoma se null
            book.AddGrade(91);
            book.AddGrade(89.5f); //to f einai gia na tu pw pws einai float auto pou tha tipwthei//
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest",(int) stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
           
        }

        static void WriteResult(string description, int result) //edw leme vgale result oson afora ta int
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult (string description, float result) 
        {
            Console.WriteLine($"{description}: {result:F2}");// edw afora ta float me th diafora pws orizoume me to $ to prwto element kai sto 2o leme kado float me dio dekadika
        }
    }
}
