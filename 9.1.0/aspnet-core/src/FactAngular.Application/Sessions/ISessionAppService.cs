using System.Threading.Tasks;
using Abp.Application.Services;
using FactAngular.Sessions.Dto;

namespace FactAngular.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
