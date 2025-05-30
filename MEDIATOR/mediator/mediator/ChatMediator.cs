using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator
{
    public class ChatMediator : IMediator
    {
        private readonly List<User> _users = new List<User>();

        public void RegisterUser(User user)
        {
            _users.Add(user);
            user.SetMediator(this);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users)
            {
                if (user != sender)
                {
                    user.ReceiveMessage(message);
                }
            }
        }
    }
}
