using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Delegates___Events.Price;

namespace Delegates___Events
{
    public class Client
    {
        private const int MaxInboxMessages = 10;

        private List<string> Inbox = new List<string>();
        private string Email {  get; set; }
        public Currency Currency { get; set; }
        private List<bool> FavouriteProducts { get; set; } = new List<bool>();

        public bool Notify(string message)
        {
            if(message.Length > 60)
            {
                return false;
            }
            if(Inbox.Count >= MaxInboxMessages)
            {
                throw new OutOfMemoryException("You have reached the maximum amount of messages.");
            }

            Inbox.Add(message);
            return true;
        }
    }
}