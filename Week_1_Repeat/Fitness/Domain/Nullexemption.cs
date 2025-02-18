namespace Domain;

public class Nullexemption : Exception
{
    public string Name { get; set; }
    public Nullexemption() : base()
    {
        System.Console.WriteLine("Error in name , you need to put something");
        string num ="";
        Name = num;
    }
}
