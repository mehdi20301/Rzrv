using Abp.Application.Services.Dto;

namespace RZRV.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}