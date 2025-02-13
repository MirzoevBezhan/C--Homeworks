namespace Domain;

public class Client : Person
{
  public  MembershipType membershipType;
  public DateTime JoinDate { get; set; }
  public List<Workout> WourkoutList { get; set; } = new List<Workout>();

  public Client(string name, int age,MembershipType membershipType) : base(name, age) { }

  public override string GetInfo()
  {
    return $"ID: {this.ID} Name: {this.Name} Age: {this.Age}";
  }
  public virtual void AddWorkout(Workout workout)
  {
    WourkoutList.Add(workout);
    System.Console.WriteLine("Workout Added");
  }

}
