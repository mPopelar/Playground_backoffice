using PlatformApi.Entities;
using PlatformApi.Queries;
using System.Collections.Generic;

namespace PlatformApi.QueryHandlers
{
    public interface IGetClientsQueryHandler : IQueryHandler<List<Client>, GetClientsQuery>
    {
    }
}
