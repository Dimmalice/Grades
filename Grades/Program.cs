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
            book.AddGrade(91);
            book.AddGrade(89.5f); //to f einai gia na tu pw pws einai float auto pou tha tipwthei//
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
           
        }
    }
}
