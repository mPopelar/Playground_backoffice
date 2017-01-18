using PlatformApi.Entities;
using System.Collections.Generic;

namespace Platform.DatasAccess.Readers
{
    public interface IClientsReader
    {
        List<Client> GetAllCLients();
    }
}
