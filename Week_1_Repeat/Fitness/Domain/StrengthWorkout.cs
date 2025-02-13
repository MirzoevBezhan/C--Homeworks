namespace Domain;

public class StrengthWorkout : Workout
{
    public double Weight { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public StrengthWorkout(string name, int Duration) : base(name, Duration) { }


    public override double CalculateCalories()
    {
        return Weight * Sets * Reps * 0.1;
    }
    
}
