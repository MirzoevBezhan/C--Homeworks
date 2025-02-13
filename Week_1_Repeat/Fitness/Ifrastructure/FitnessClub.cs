using Domain;
namespace Ifrastructure;
public class FitnessClub
{
    public List<Client> Clients { get; set; } = new List<Client>();
    public List<Trainer> Trainers { get; set; } = new List<Trainer>();
    public List<Workout> Workouts { get; set; } = new List<Workout>();
    public void AddClient(Client client)
    {
        Clients.Add(client);
        System.Console.WriteLine("Client Added");
    }

    public void AddTrainer(Trainer trainer)
    {
        Trainers.Add(trainer);
        System.Console.WriteLine("Trainer Added");
    }
    public void AssignTrainer(Client client, Trainer trainer)
    {
        foreach (var item in Trainers)
        {
            if (item == trainer)
            {
                item.AddClient(client);
                System.Console.WriteLine("Client Added to Trainer");
            }
        }
    }
    public void AddWorkout(Workout workout)
    {
        Workouts.Add(workout);
        System.Console.WriteLine("Workout Added");
    }
    public void DisplayStats()
    {
        System.Console.WriteLine($"Clients: {Clients.Count}");
        System.Console.WriteLine($"Trainers: {Trainers.Count}");
        System.Console.WriteLine($"Workout: {Workouts.Count}");
    }
}
