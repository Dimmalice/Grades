﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class ThrowAwayGradeBook : GradeBook //INHERITANCE: dinei sto throwAway tis idies idiotites me to GradeBook
    {
        public override GradeStatistics ComputeStatistics()
        {

            float lowest = float.MaxValue;
            foreach (float grade in grades)
            {
                lowest = Math.Min(grade, lowest);
            }
            grades.Remove(lowest);

           return  base.ComputeStatistics();
        }

    }
}
