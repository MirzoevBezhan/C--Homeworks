using Domain;
using Infastructure;
while (true)
{
    Console.WriteLine("1. Registration");
    Console.WriteLine("2. Login");
    Console.WriteLine("3. Send Message");
    Console.WriteLine("4. See Message");
    Console.WriteLine("5. Change Status");
    Console.WriteLine("6. Exit");
    string Function = Console.ReadLine();
    while (true)
    {

        if (Function == "1")
        {
            Console.WriteLine("1. Registration");
            System.Console.Write("Choose Name: ");
            string? name = Console.ReadLine();
            if (SocialNetwork.RegisterUser(name))
            {
                System.Console.WriteLine("Register successful finish");
            }
            else
            {
                System.Console.WriteLine("!!!!!!Error!!!!!!");
            }
        }
        if (Function == "2")
        {

            Console.WriteLine("2. Login");
            System.Console.Write("Choose Name: ");
            string? userName = Console.ReadLine();
            if (SocialNetwork.Login(userName))
            {
                System.Console.WriteLine("Success login");
            }
            else
            {
                System.Console.WriteLine("Error");
            }
        }
        if (Function == "3")
        {
            Console.WriteLine("3. Send Message");
            System.Console.Write("Write Message: ");
            string? Soobshenie = Console.ReadLine();
            SocialNetwork.SendMessage(Soobshenie, MessageType.Text);
            System.Console.WriteLine("Sended");
        }
        if (Function == "4")
        {
            var messages = SocialNetwork.GetLastMessages(5);
            foreach (var msg in messages)
            {
                Console.WriteLine(msg);
            }
        }
        if (Function == "5")
        {
            {
                Console.WriteLine("5. Change status");

                UserStatus newStatus = UserStatus.Offline;
                SocialNetwork.ChangeUserStatus(newStatus);
            }
        }

        if (Function == "6")
        {
            System.Console.WriteLine("Have a nice day");
            break;
            return;
        }
    }
}
