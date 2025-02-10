namespace Infastructure;

public class Teacher : Person
{
    private int NumCourse = 0;
    private string[] Strings = { };
    public Teacher(string adress, string name) : base(adress, name)
    { }
    public bool AddCourse(string course){
    this.Strings[NumCourse]=course;
    NumCourse++;
    return true;
    }
    public bool RemoveCourse(string  course){
       foreach (var item in NumCourse)
       {
        if (Strings.it==course)
        {
            item--;
        }
       }
    }

     public string ToString()
    {
        return $"Name: {this.name} Adress: {this.adress}";
    }

}
