using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass_Dict
{
    class Course
    {

        public int CourseID { get; set; }
        public string CourseTitle { get; set; }

        private Dictionary<Student, Double> dict = new Dictionary<Student, double>();

        public Course(int courseID, string courseTitle)
        {
            this.CourseID = courseID;
            this.CourseTitle = courseTitle;
        }


        public void addStudent(Student p, double g)
        {
            dict.Add(p, g);
        }

        public void RemoveStudent(int StudentID)
        {
            foreach (KeyValuePair<Student, double> item in dict)
            {
                if (item.Key.StudentID == StudentID)
                {
                    dict.Remove(item.Key);
                    break;
                }
            }
        }


        public override string ToString()
        {
            string result = $"Course: {CourseID} - {CourseTitle} \n";
            foreach(KeyValuePair<Student, double> item in dict)
            {
                result += $"Student: {item.Key} - Mark: {item.Value.ToString().Replace(".",",")}\n";
            }
            return result;
        }



    }
}
