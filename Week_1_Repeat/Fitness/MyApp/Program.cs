using Domain;
using Ifrastructure;
try
{
FitnessClub fitnessClub = new FitnessClub();

Client client = new Client("Sdfman", 18, MembershipType.Premium);
Trainer trainer = new Trainer("Alisher", 12, client);
Workout workout = new CardioWorkout("MMA", 2);
Workout workout2 = new CardioWorkout("Jiu Jitsu", 1);

System.Console.Write("Put Yusuf's age: ");
int age = Convert.ToInt32(Console.ReadLine());
Client client1 = new Client("Yusuf", age, MembershipType.Standard);

System.Console.WriteLine();
fitnessClub.AddClient(client);
fitnessClub.AddClient(client1);
System.Console.WriteLine();
fitnessClub.AddWorkout(workout);
fitnessClub.AddWorkout(workout2);

System.Console.WriteLine();
client.AddWorkout(workout);
client1.AddWorkout(workout2);
System.Console.WriteLine();
fitnessClub.DisplayStats();

System.Console.WriteLine();
fitnessClub.AddTrainer(trainer);
fitnessClub.AssignTrainer(client, trainer);
fitnessClub.AssignTrainer(client1, trainer);

System.Console.WriteLine();
System.Console.WriteLine(client.GetInfo());
System.Console.WriteLine(client1.GetInfo());
System.Console.WriteLine(trainer.GetInfo());
System.Console.WriteLine();
fitnessClub.DisplayStats();
}
catch (FormatException form)
{
    System.Console.WriteLine("Format Error change type of variable");
}