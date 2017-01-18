using System.Collections.Generic;
using PlatformApi.Entities;
using PlatformApi.Queries;
using PlatformApi.QueryHandlers;
using Platform.DatasAccess.Readers;

namespace Platform.QueryHandlers
{
    public class GetClientsQueryHandler : IGetClientsQueryHandler
    {
        private readonly IClientsReader _clientReader;

        public GetClientsQueryHandler(IClientsReader clientReader)
        {
            _clientReader = clientReader;
        }
        
        public List<Client> Execute(GetClientsQuery query)
        {
            return _clientReader.GetAllCLients();
        }
    }
}
