using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook //klasi
    {

        public GradeBook() //CONSTRUCTOR. patisa ctor kai meta diplo TAB kai to kanei automata. To PUBLIC einai access modifier 
                           //an diladi svisw to PUBLIC tote to program.cs de tha borei na kanei retrieve kai na trexei tis adistoixes edoles pou einai public
                           //auto einai gia logous asfaleias
        {
                grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics() //constructor
        {
            GradeStatistics stats =  new GradeStatistics(); // constructor
           

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
        

        public void AddGrade(float grade) //constructor. to void simainei pws h methodos den epistrefei kapio value enw sto proigoumeno constr. epistrefei to computestats
        {
            grades.Add(grade);
        }

        public string Name // ews kai th grammi 56 orizoume ena property wste na mhn ginetai na alaksei to name tou vivliou 
        {
            get
            {
                return _name;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }
        private string _name;
        private List <float> grades;
        
    }
}
