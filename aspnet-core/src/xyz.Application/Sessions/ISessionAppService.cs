using System.Threading.Tasks;
using Abp.Application.Services;
using xyz.Sessions.Dto;

namespace xyz.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
