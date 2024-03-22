using Abp.Application.Services;
using FactAngular.MultiTenancy.Dto;

namespace FactAngular.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

