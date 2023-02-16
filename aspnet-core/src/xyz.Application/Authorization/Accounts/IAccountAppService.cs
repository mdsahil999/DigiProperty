using System.Threading.Tasks;
using Abp.Application.Services;
using xyz.Authorization.Accounts.Dto;

namespace xyz.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
