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
        public void addClient(Client client) {
            clients.Add(client);
            Console.WriteLine("Client added");
        }
        public void deleteClient(Client client) {
            clients.Remove(client);
            Console.WriteLine("Client deleted");
        }
        public void showAll() {
            foreach (Client c in clients) {
                Console.WriteLine( c.getFirstName() + " " + c.getName() + " " + c.getAge() + " years old.");
            }
        }
    }
}
