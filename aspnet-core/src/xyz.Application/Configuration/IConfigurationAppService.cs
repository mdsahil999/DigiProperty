using System.Threading.Tasks;
using xyz.Configuration.Dto;

namespace xyz.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
