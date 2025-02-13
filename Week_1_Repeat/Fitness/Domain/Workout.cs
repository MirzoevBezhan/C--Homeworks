namespace Domain;

public abstract class Workout
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Duration { get; set; }

    public Workout(string name, int Duration)
    {
        this.ID = Guid.NewGuid().ToString();
        this.Name = name;
        this.Duration = Duration;
    }
    public abstract double CalculateCalories();

}
