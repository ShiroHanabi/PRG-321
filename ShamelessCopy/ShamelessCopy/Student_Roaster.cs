using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamelessCopy
{
    public class Student_Roster : Dictionary<int, student>
    {

        public void Add(int student_id, student Student)
        {
            base.Add(student_id, Student);


        }

    }

}
