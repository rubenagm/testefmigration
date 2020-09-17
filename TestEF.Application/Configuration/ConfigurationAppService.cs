using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TestEF.Configuration.Dto;

namespace TestEF.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TestEFAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
