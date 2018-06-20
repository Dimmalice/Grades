using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
   public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter destination);
        public abstract IEnumerator GetEnumerator();


        public string Name // ews kai th grammi 56 orizoume ena property wste na mhn ginetai na alaksei to name tou vivliou 
        {
            get
            {
                return _name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                {
                    if (_name != value && NameChanged != null)
                    {
                        if (_name != value)
                        {
                            NameChangedEventArgs args = new NameChangedEventArgs();
                            args.ExistingName = _name;
                            args.NewName = value;

                            NameChanged(this, args);

                        }

                        _name = value;
                    }
                }
            }
        }



        public event NameChangedDelegate NameChanged;
        protected string _name;
    }
}
