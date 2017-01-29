using PlatformApi.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Platform.DatasAccess.Readers
{
    public class ClientsReader : IClientsReader
    {
        private readonly PlatformContext _context;

        public ClientsReader(PlatformContext context)
        {
            _context = context;
        }
        
        public List<Client> GetAllCLients()
        {
            return _context.Clients.ToList();
        }

        public Client GetClientById()
        {
            return _context.Clients.FirstOrDefault();
        }
    }
}
