using System.Security.Cryptography;

namespace Infastructure;

public class Student
{
    public string Name;
    private int _age;
    public int Age
    {
        get
        {
            if (_age < 16) { return _age; }
            return _age;
        }
        set
        {
            if (value < 16) { _age = 0; }
            if (value > 16) { _age = 18; }
            _age = value;
        }
    }

        
    public double AverageGrade { get; set; }
    public int Id { get; set; }
    public Student(string Name, int age, double AverageGrade, int Id = 0)
    {
        this.Name = Name;
        this.Age = age;
        this.AverageGrade = AverageGrade;
        this.Id = Id;
        this.Id += 1;
    }
    public void PrintInfo()
    {
        System.Console.WriteLine($"Name: {this.Name} - Age: {this.Age}");
        System.Console.WriteLine($"Id: {this.Id} - AverageGrade: {this.AverageGrade}");
    }
    public void UpdateGrade(double newGrade)
    {
        if (this.AverageGrade > 0 && this.AverageGrade <= 10)
        {
            this.AverageGrade = newGrade;
            System.Console.WriteLine("Changed");
        }
        else
        {
            System.Console.WriteLine("Don't changed");
        }
    }

}
