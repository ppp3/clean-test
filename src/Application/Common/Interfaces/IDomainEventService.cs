using template.Domain.Common;
using System.Threading.Tasks;

namespace template.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
