using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FactAngular.Configuration.Dto;

namespace FactAngular.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FactAngularAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
