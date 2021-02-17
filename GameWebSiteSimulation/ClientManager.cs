using System;
using System.Collections.Generic;
namespace GameWebSiteSimulation
{
     
    public class ClientManager : IClientManager
    {
        private List<Client> clients;

        public ClientManager()
        {
            clients = new List<Client>();
        }
        public void Add(object client) {
            clients.Add((Client)client);
            Console.WriteLine("Client added");
        }
        public void Delete(object client) {
            clients.Remove((Client)client);
            Console.WriteLine("Client deleted");
        }
        public void ShowAll() {
            foreach (Client c in clients) {
                Console.WriteLine( c.firstName + " " + c.name + " " + c.getAge() + " years old.");
            }
        }
    }
}
