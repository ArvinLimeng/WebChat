using System;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message, string datetime, string receiver)
        {
            Clients.All.broadcastMessage(name, message, datetime, receiver);
        }
    }
}