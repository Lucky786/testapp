using System;
using System.Threading.Tasks;
using VoipProjectEntities.Domain.Entities;

namespace VoipProjectEntities.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
    }
}