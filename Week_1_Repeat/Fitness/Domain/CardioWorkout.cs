namespace Domain;

public class CardioWorkout : Workout
{
    public double Distance { get; set; }
    public Intensity intensity;
    public CardioWorkout(string name, int Duration) : base(name, Duration) { }
    public override double CalculateCalories()
    {
        return Distance*50;
    }


}
