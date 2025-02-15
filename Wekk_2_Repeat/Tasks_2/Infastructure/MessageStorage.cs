namespace Infastructure;

public class MessageStorage<T>
{
    public List<T> Messages = new List<T>();
    public void Add(T message)
    {
        Messages.Add(message);
        System.Console.WriteLine("Message Added");
    }
    public List<T> GetLastMessages(int count)
    {
        List<T> Count = new List<T>();
        for (int i = 0; i < count; i++)
        {
            foreach (var item in Messages)
            {
                Count.Add(item);
            }
        }
        return Count;
    }
    public void Clear()
    {
        Messages.Clear();
        System.Console.WriteLine("All messages Deleted");
    }
    public int Count(){
        return Messages.Count;
    }
}
