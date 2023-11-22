using Microsoft.AspNetCore.SignalR;

namespace SimpleChat.Hubs
{
    public class SimpleChart : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",user, message);
        }
    }
}
