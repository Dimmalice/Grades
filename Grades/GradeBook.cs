using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker //klasi
    {

        public GradeBook() //CONSTRUCTOR. patisa ctor kai meta diplo TAB kai to kanei automata. To PUBLIC einai access modifier 
                           //an diladi svisw to PUBLIC tote to program.cs de tha borei na kanei retrieve kai na trexei tis adistoixes edoles pou einai public
                           //auto einai gia logous asfaleias
        {
            _name = "Grade Book";
            grades = new List<float>();
        }



        public override GradeStatistics ComputeStatistics() //constructor
        {
            GradeStatistics stats = new GradeStatistics(); // constructor


            float sum = 0;
            foreach (float grade in grades) //gia kathe ena grade apo ta grades
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade; //mesos oros
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public override void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }

        public override void AddGrade(float grade) //constructor. to void simainei pws h methodos den epistrefei kapio value enw sto proigoumeno constr. epistrefei to computestats
        {
            grades.Add(grade);
        }

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }
        protected List<float> grades;//me to protected mporoume na exoume prosvasi apo kwdika ths idias klasis 

    }
}
