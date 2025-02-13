using System.Collections.Concurrent;

namespace Domain;

public class Trainer : Person
{
    public string Specializators { get; set; }
    public List<Client> Clients { get; set; } = new List<Client>();
    public Trainer(string name, int age,Client client) : base(name, age) { 
        Clients.Add(client);
    }
    public override string GetInfo()
    {
        return $"ID: {this.ID} Name: {this.Name} Age: {this.Age}";
    }
    public virtual void AddClient(Client client)
    {
     Clients.Add(client);
     System.Console.WriteLine("Client Added");
    }
    
}
