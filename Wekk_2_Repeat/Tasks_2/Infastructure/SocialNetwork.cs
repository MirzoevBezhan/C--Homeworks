namespace Infastructure;
using Domain;
public class SocialNetwork
{
    static List<User> users = new List<User>();
    static MessageStorage<Message> messageStorages = new MessageStorage<Message>();
    static User CurUser;
    public static bool Login(string name)
    {
        foreach (var item in users)
        {
            if (item.Name == name)
            {
                CurUser = item;
                CurUser.ChangeStatus(UserStatus.Online);
                return true;
            }
        }
        return false;
    }
    public static bool RegisterUser(string name)
    {
        foreach (var item in users)
        {
            if (item.Name == name)
            {
                return false;
            }
        }
        User newUser = new User(name);
        newUser.AddFriend(name);
        return true;
    }

    public static void SendMessage(string text, MessageType type)
    {
        if (CurUser == null)
        {
            return;
        }
        var NewMessage = new Message(CurUser.Name, text, type);
        messageStorages.Add(NewMessage);
    }
    public static List<Message> GetLastMessages(int count)
    {
        return messageStorages.GetLastMessages(count);
    }
    public static void ChangeUserStatus(UserStatus newStatus)
    {
        CurUser.ChangeStatus(newStatus);
    }
}
