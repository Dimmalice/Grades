using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics

    {

        public GradeStatistics()
        {
           HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public float AverageGrade; // alt key patimeno k epilegeis osa thes to kanei se ola.
        public float HighestGrade;
        public float LowestGrade;
    }
}
