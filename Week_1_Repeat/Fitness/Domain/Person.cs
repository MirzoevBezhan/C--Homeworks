using System.Globalization;

namespace Domain;

public abstract class Person
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        this.ID = Guid.NewGuid().ToString();
        this.Name = name;
        this.Age = age;
    }
   public abstract string GetInfo();
}
