using System;
using Mediator_Pattern.Users;
using Mediator_Pattern.Mediators;
namespace Mediator_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChatMediator chat = new ChatMediator();
            SimpleUser user1 = new SimpleUser(chat, "VaneaRacheta");
            SimpleUser user2 = new SimpleUser(chat, "JoraMustang");
            SimpleUser user3 = new SimpleUser(chat, "SaneaCecenu");

            chat.AddSimpleUsersToChat(user1);
            chat.AddSimpleUsersToChat(user2);
            chat.AddSimpleUsersToChat(user3);

            user1.SendMessageToAll("Zdaroa la toti patanii!");
            user2.SendMessageToUser("Sanea, cum acolo in Mariupol?", "SaneaCecenu");

        }
    }
}
