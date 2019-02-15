using System;
using Microsoft.AspNetCore.SignalR.Client;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var hc = new HubConnectionBuilder().WithUrl("http://localhost:50003/testHub").Build();

            hc.On<dynamic>("receiveMessage", (o) =>
            {
                Console.WriteLine($"{o}");
            });



            try
            {
                hc.StartAsync().Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            hc.SendAsync("TestMessage", "pichugins", "hello world message");









            Console.ReadLine();
        }
    }
}