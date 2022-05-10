using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator_Pattern.Users;

namespace Mediator_Pattern.Mediators
{
    class ChatMediator : IChatMediator
    {

        private List<SimpleUser> _simpleUsers;
        public ChatMediator()
        {
            _simpleUsers = new List<SimpleUser>();
        }

        public void AddSimpleUsersToChat(SimpleUser user)
        {
            _simpleUsers.Add(user);
        }

        public void SendMessageToAll(string message, UserBase from)
        {
            foreach (var user in _simpleUsers)
                if (user != from)
                    user.ReceiveMessage(message, from.Id);
        }

        public void SendMessageToUser(string message, UserBase from, string toID)
        {
            var to = _simpleUsers.FirstOrDefault(x => x.Id == toID);

            if (to == null)
            {
                System.Console.WriteLine($"User {toID} doesn't exist");
            }
            else
                to.ReceiveMessage(message, from.Id);
        }
    }
}
