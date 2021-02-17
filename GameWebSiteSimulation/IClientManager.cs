using System;
namespace GameWebSiteSimulation
{
    public interface IClientManager
    {
        public void addClient(Client client);
        public void deleteClient(Client client);
        public void showAll();

    }
}
