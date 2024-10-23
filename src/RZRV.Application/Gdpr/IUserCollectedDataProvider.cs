using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using RZRV.Dto;

namespace RZRV.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
