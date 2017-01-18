using PlatformApi.Entities;
using System.Collections.Generic;

namespace Platform.DatasAccess.Readers
{
    public class ClientsReader : IClientsReader
    {
        public List<Client> GetAllCLients()
        {
            var list = new List<Client>
            {
                new Client { Id = 1, Name = "First Client" }
            };

            return list;
        }
    }
}
