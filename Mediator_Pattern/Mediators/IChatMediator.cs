using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator_Pattern.Users;

namespace Mediator_Pattern.Mediators
{
    interface IChatMediator
    {
        void SendMessageToAll(string message, UserBase from);

        void SendMessageToUser(string message, UserBase from, string toID);
    }
}
