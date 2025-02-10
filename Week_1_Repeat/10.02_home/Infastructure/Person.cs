using System.Diagnostics.Contracts;

namespace Infastructure;

public class Person
{
    protected string name;
    protected string adress;
    public Person(string name, string adress)
    {
        this.name = name;
        this.adress = adress;
    }
    public string GetName()
    {
        return this.name;
    }
    public string GetAdress()
    {
        return this.adress;
    }
    public void SetAdress(string adress)
    {
        this.adress = adress;
    }
    public string ToString()
    {
        return $"Name: {this.name} Adress: {this.adress}";
    }

}
