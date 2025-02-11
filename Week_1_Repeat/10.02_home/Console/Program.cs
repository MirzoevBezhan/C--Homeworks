using Infastructure;

Student student = new Student("Maskovskiy", "Sanya");
student.AddCourseGrade("Math", 150);
student.PrintGrades();
System.Console.WriteLine(student.ToString());
System.Console.Write("Average grade: ");
System.Console.WriteLine(student.GetAverageGrade());
