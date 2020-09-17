using System.Threading.Tasks;
using Abp.Application.Services;
using TestEF.Configuration.Dto;

namespace TestEF.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}