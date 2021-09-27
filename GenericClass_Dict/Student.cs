using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass_Dict
{
    class Student
    {

        public Student()
        {
        }

        public Student(int studentID, string studentName)
        {
            StudentID = studentID;
            StudentName = studentName;
        }

        public int StudentID { get; set ; }
        public string StudentName { get ; set; }

        public override string ToString()
        {
            return StudentID+" - "+StudentName;
        }
    }
}
