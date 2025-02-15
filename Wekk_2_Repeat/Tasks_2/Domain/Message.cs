namespace Infastructure;
using Domain;
public class Message
{
    public string Author { get; set; }
    public string Text { get; set; }
    public MessageType Type { get; set; }
    public DateTime dateTime { get; set; }
    public Message(string author, string text, MessageType type)
    {
        Author = author;
        Text = text;
        Type = type;
        dateTime = DateTime.Now;

    }
    public override string ToString()
    {
        return $"{Author} - {Text} - {Type} , {dateTime}";
    }
}
