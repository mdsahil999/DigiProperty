using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using xyz.Configuration.Dto;

namespace xyz.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : xyzAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
