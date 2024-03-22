using System.Threading.Tasks;
using FactAngular.Configuration.Dto;

namespace FactAngular.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
