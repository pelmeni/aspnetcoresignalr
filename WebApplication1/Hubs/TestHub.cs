using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace WebApplication1.Hubs
{
    public class TestHub:Hub
    {
        public async Task TestMessage(string user, string message)
        {

            await Clients.Caller.SendCoreAsync("receiveMessage", new[] {"user message sent with success!"});
            
            Console.WriteLine($"user: {user}, message: {message}");
        }
    }
}