using Abp;
using Abp.Domain.Services;
using System.Threading.Tasks;

namespace RZRV.Authorization.Users.Profile
{
    public interface IProfileImageService : IDomainService
    {
        Task<string> GetProfilePictureContentForUser(UserIdentifier userIdentifier);
    }
}