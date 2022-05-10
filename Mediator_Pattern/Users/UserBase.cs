using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator_Pattern.Mediators;


namespace Mediator_Pattern.Users
{
    abstract class UserBase
    {
        protected IChatMediator _mediator;
        public readonly string Id;
        public UserBase(IChatMediator mediator, string id)
        {
            _mediator = mediator;
            Id = id;
        }

        public abstract void SendMessageToAll(string message);
        public abstract void SendMessageToUser(string message, string toId);
        public abstract void ReceiveMessage(string message, string fromId);

    }
}
