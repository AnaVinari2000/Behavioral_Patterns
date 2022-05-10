using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator_Pattern.Mediators;

namespace Mediator_Pattern.Users
{
    class SimpleUser : UserBase
    {
        public SimpleUser(IChatMediator mediator, string id) : base(mediator, id)
        {

        }

        public override void ReceiveMessage(string message, string fromId)
        {
            Console.WriteLine($"User {this.Id} received {message} from {fromId}");
        }

        public override void SendMessageToAll(string message)
        {
            _mediator.SendMessageToAll(message, this);
        }

        public override void SendMessageToUser(string message, string toId)
        {
            _mediator.SendMessageToUser(message, this, toId);
        }
    }
}
