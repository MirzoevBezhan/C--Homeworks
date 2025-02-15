namespace Infastructure;
using Domain;

public class User
{
    public string Name { get; set; }
    public UserStatus Status { get; set; }
    List<string> friemds;

    public User(string name)
    {
        Name = name;
    }

    public void ChangeStatus(UserStatus newStatus)
    {
        Status = newStatus;
    }
    public bool AddFriend(string friendName)
    {
        if (friemds.Contains(friendName))
        {
            friemds.Add(friendName);
            return true;
        }
        return false;
    }
    public List<string> GetFriends()
    {
        return new List<string>(friemds);
    }
    public override string ToString()
    {
        return $"Имя: {Name} - (Статус: {Status})";
    }
}
