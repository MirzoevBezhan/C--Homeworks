namespace Infastructure;

public class Group
{
    public string Name { get; set; }
    public readonly int CountOfStudent;
    public List<Student> Students { get; set; }
    public void AddStudent(Student student)
    {
        Students.Add(student);
        System.Console.WriteLine("Added new Student");
    }
    public void RemoveStudent(int id)
    {
        foreach (var item in Students)
        {
            if (item.Id == id)
            {
                Students.Remove(item);
            }
        }
    }
    public void FindStudent(int id)
    {
        foreach (var item in Students)
        {
            if (item.Id == id)
            {
                System.Console.WriteLine("Finden");
                System.Console.WriteLine($"Name: {item.Name}");
                System.Console.WriteLine($"Age: {item.Age}");
                System.Console.WriteLine($"AverageGrade: {item.AverageGrade}");
                System.Console.WriteLine($"ID: {item.Id}");
            }
            else
            {
                System.Console.WriteLine("Don't finden");
            }
        }
    }
    public void GetTopStudents(int count)
    {
        Students.Sort();
        for (int i = 0; i <= count; i++)
        {
            foreach (var item in Students)
            {
                    System.Console.WriteLine($"Name: {item.Name} Age: {item.Age} AverageGrade: {item.AverageGrade} Id: {item.Id}");
            }
        }

    }


}
