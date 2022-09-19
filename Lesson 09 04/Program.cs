using System;
using System.Collections.Generic;

namespace Lesson_09_04
{
    internal class Program
    {
        static void showStudents(List<Student> studentList)
        {
            foreach (Student student in studentList)
            {
                Console.WriteLine(student.StudentId);
            }
        }
        public struct Student
        {
            public bool PassedExam;
            public int StudentId;

            public Student(int studentId, bool passedExam)
            {
                PassedExam = passedExam;
                StudentId = studentId;
            }
        }
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            Student student1 = new Student(123, true);
            Student student2 = new Student(321, false);
            Student student3 = new Student(666, true);

            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);

            showStudents(studentList);

        }


    }
}
