using System.Diagnostics;
using Microsoft.AspNetCore.SignalR;

namespace BlazorApp.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Debug.Print($"SendMessage: {Context.ConnectionId}");
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public override Task OnConnectedAsync()
        {
            Debug.Print($"OnConnectedAsync: {Context.ConnectionId}");
            
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            Debug.Print($"OnDisconnectedAsync: {Context.ConnectionId}");

            return base.OnDisconnectedAsync(exception);
        }
    }
}