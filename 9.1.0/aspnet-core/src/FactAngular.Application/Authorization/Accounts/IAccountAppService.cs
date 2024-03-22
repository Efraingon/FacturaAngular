using System.Threading.Tasks;
using Abp.Application.Services;
using FactAngular.Authorization.Accounts.Dto;

namespace FactAngular.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
