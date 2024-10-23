using System.Threading.Tasks;
using Abp.Application.Services;
using RZRV.Install.Dto;

namespace RZRV.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}