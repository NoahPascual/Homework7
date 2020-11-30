// Noah Pascual
// MIS 3013 995
// Homework 7 - Classes

// You will be creating a student class using the UML below. 
// In your Program.cs in the Main method, make 3 instances (objects) of the Student class using each type of constructor and then populate them with data (hard-coded). 
// Once you have populated them with data (including grades), output the students with all of the averages for their grades.

        // FirstName : string
        // LastName : string
        // StudentId : int
        // ExamGrades : List<double>
        // FinalExamGrades : List<double>
        // HomeworkGrades : List<double>
        // ParticipationGrades : List<double>
        // QuizGrades : List<double>

        // Student()
        // Student(int studentId)
        // Student(string firstName, string lastName, int studentId)
        // ToString() : string
        // CalculateExamAverage() : double
        // CalculateFinalExamAverage() : double
        // CalculateHomeworkAverage() : double
        // CalculateParticipationAverage() : double
        // CalculateQuizAverage() : double

    //ToString() - Returns a string representation of the instance of the class.  The format of the string should be: LastName, FirstName(StudentId)
    //CalculateExamAverage() - Returns a double that is the average of the exam grades for the student.
    //CalculateFinalExamAverage ( ) -Returns a double that is the average of the final exam grades for the student.
    //CalculateHomeworkAverage ( ) -Returns a double that is the average of the homework grades for the student.
    //CalculateParticipationAverage ( ) -Returns a double that is the average of the participation grades for the student.
    //CalculateQuizAverage ( ) -Returns a double that is the average of the quiz grades for the student.

using System;
using System.Collections.Generic;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.FirstName = "Noah";
            student1.LastName = "Pascual";
            student1.StudentID = 1039559;

            student1.ExamGrades = new List<double>() {90, 70, 80, 55, 78};
            student1.FinalExamGrade = new List<double>() { 90, 90, 90, 100, 88 };
            student1.HomeworkGrades = new List<double>() { 99, 88, 80, 90, 87 };
            student1.ParticpationGrades = new List<double>() { 88, 90, 90, 77, 90 };
            student1.QuizGrades = new List<double>() { 100, 55, 100, 77, 90 };

            Student student2 = new Student(1087865);
            student2.FirstName = "James";
            student2.LastName = "Franco";

            student2.ExamGrades = new List<double>() { 80, 79, 60, 90, 100 };
            student2.FinalExamGrade = new List<double>() { 88, 90, 90, 77, 90 };
            student2.HomeworkGrades = new List<double>() { 99, 88, 80, 90, 87 };
            student2.ParticpationGrades = new List<double>() { 84, 79, 77, 90, 90 };
            student2.QuizGrades = new List<double>() { 90, 90, 90, 100, 88 };

            Student student3 = new Student("William", "Frank", 1249908);
            student3.ExamGrades = new List<double>() { 84, 79, 77, 90, 90 };
            student3.FinalExamGrade = new List<double>() { 100, 55, 100, 77, 90 };
            student3.HomeworkGrades = new List<double>() { 90, 90, 90, 100, 88 };
            student3.ParticpationGrades = new List<double>() { 90, 70, 80, 55, 78 };
            student3.QuizGrades = new List<double>() { 88, 90, 90, 77, 90 };

            Console.WriteLine(student1);
            Console.WriteLine("\t Exam Average: " + student1.CalculateExamAverage());
            Console.WriteLine("\t Final Exam Average: " + student1.CalculateFinalExamAverage());
            Console.WriteLine("\t Homework Average: " + student1.CalculateHomeworkGradesAverage());
            Console.WriteLine("\t Participation Average: " + student1.CalculateParticpationGradesAverage());
            Console.WriteLine("\t Quiz Average: " + student1.CalculateQuizGradesAverage());

            Console.WriteLine(student2);
            Console.WriteLine("\t Exam Average: " + student2.CalculateExamAverage());
            Console.WriteLine("\t Final Exam Average: " + student2.CalculateFinalExamAverage());
            Console.WriteLine("\t Homework Average: " + student2.CalculateHomeworkGradesAverage());
            Console.WriteLine("\t Participation Average: " + student2.CalculateParticpationGradesAverage());
            Console.WriteLine("\t Quiz Average: " + student2.CalculateQuizGradesAverage());

            Console.WriteLine(student3);
            Console.WriteLine("\t Exam Average: " + student3.CalculateExamAverage());
            Console.WriteLine("\t Final Exam Average: " + student3.CalculateFinalExamAverage());
            Console.WriteLine("\t Homework Average: " + student3.CalculateHomeworkGradesAverage());
            Console.WriteLine("\t Participation Average: " + student3.CalculateParticpationGradesAverage());
            Console.WriteLine("\t Quiz Average: " + student3.CalculateQuizGradesAverage());

            Console.ReadKey();
        }
    }
}
