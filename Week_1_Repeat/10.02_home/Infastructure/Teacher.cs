namespace Infastructure;

public class Teacher : Person
{
    private int MaxCourse = 5;
    List<string> courses = new List<string>();
    public Teacher(string adress, string name) : base(adress, name)
    { }
    public void AddCourse(string course)
    {
        if (courses.Count < MaxCourse)
        {
            courses.Add(course);
        }
    }
    public bool RemoveCourse(string course)
    {
        foreach (var item in courses)
        {
            if (item == course)
            {
                courses.Remove(item);
                return true;
            }
        }
        return false;
    }

    public string ToString()
    {
        return $"Name: {this.name} Adress: {this.adress}";
    }

}
