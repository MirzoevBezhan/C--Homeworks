namespace Infastructure;

public class Student : Person
{
    public Student(string adress, string name) : base(adress, name)
    { }
    private int NumCourse = 0;
    private string[] Strings = { };
    private int[] Grades = {  };

    public void AddCourseGrade(string course, int grades)
    {
        NumCourse++;
        this.Strings[NumCourse] = course;
        this.Grades[NumCourse] = grades;
    }
    public void PrintGrades()
    {
        System.Console.Write("Grades: ");
        foreach (var item in Grades)
        {
            System.Console.Write(item);
        }
        System.Console.WriteLine();
    }
    public double GetAverageGrade()
    {
        double cnt = 0;
        double sum = 0;
        foreach (var item in Grades)
        {
            sum += item;
            cnt++;
        }
        return sum / cnt;
    }
    public string ToString()
    {
        return $"Name: {this.name} Adress: {this.adress}";
    }


}
