using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMaterialChat.Shared.Helpers;
using BlazorMaterialChat.Shared.Models;
using Microsoft.AspNetCore.SignalR;
using MudBlazor;

namespace BlazorMaterialChat.Server.Hubs
{
    public class ChatHub : Hub
    {

        private static readonly Dictionary<string, string> UserLookup = new Dictionary<string, string>();
        
        
        public async Task SendMessage(string username, string message)
        {
            await Clients.All.SendAsync(Messages.RECEIVE, username, message);
        }

        public async Task Register(string username)
        {
            var curentId = Context.ConnectionId;
            if (!UserLookup.ContainsKey(curentId))
            {
                UserLookup.Add(curentId, username);
                await Clients.AllExcept(curentId).SendAsync(
                    Messages.RECEIVE, 
                    username, $"{username} has joined the chat");
            }
        }

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            string id = Context.ConnectionId;
            if (!UserLookup.TryGetValue(id, out string username))
                username = "[username]";

            UserLookup.Remove(id);
            
            await Clients.AllExcept(id).SendAsync(
                    Messages.RECEIVE, 
                    username, $"{username} has left the chat");
            await base.OnDisconnectedAsync(exception);
        }
    }
}