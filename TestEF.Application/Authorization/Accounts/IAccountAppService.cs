using System.Threading.Tasks;
using Abp.Application.Services;
using TestEF.Authorization.Accounts.Dto;

namespace TestEF.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
