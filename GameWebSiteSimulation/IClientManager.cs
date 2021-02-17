using System;
namespace GameWebSiteSimulation
{
    public interface IClientManager
    {
        public void Add(object o);
        public void Delete(object o);
        public void ShowAll();

    }
}
