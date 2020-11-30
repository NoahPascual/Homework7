using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7
{
    class Student
    {
        public string FirstName { get; set; } // FirstName : string
        public string LastName { get; set; } // LastName : string
        public int StudentID { get; set; } // StudentId : int
        public List<double> ExamGrades { get; set; } // ExamGrades : List<double>
        public List<double> FinalExamGrade { get; set; } // FinalExamGrades : List<double>
        public List<double> HomeworkGrades { get; set; } // HomeworkGrades : List<double>
        public List<double> ParticpationGrades { get; set; } // ParticipationGrades : List<double>
        public List<double> QuizGrades { get; set; } // QuizGrades : List<double>

        public Student() // Student()
        {

        }

        public Student(int StduentID)  // Student(int studentId)
        {
            this.StudentID = StudentID;
        }

        public Student(string FirstName, string LastName, int StudentID) //Student(string firstName, string lastName, int studentId)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.StudentID = StudentID;
        }

        public override string ToString() //ToString() : string
        {
            return LastName +"," + FirstName +"(" + StudentID +")";
        }

        public double CalculateExamAverage() // Calculated Exam Average
        {
            double sum = 0;
            foreach (double i in ExamGrades)
            {
                sum += i;
            }
            return sum / 5;
        }
        public double CalculateFinalExamAverage() // Calculated Final Exam Average
        {
            double sum = 0;
            foreach (double i in FinalExamGrade)
            {
                sum += i;
            }
            return sum / 5;
        }
        public double CalculateHomeworkGradesAverage() // Calculated Homework Average
        {
            double sum = 0;
            foreach (double i in HomeworkGrades)
            {
                sum += i;
            }
            return sum / 5;
        }
        public double CalculateParticpationGradesAverage() // Calculated Participation Average
        {
            double sum = 0;
            foreach (double i in ParticpationGrades)
            {
                sum += i;
            }
            return sum / 5;
        }

        public double CalculateQuizGradesAverage() // Calculated Quiz Average
        {
            double sum = 0;
            foreach (double i in QuizGrades)
            {
                sum += i;
            }
            return sum / 5; 
        }

    }
}
