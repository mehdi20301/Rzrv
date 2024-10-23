using Abp.Application.Services.Dto;

namespace RZRV.Modal.Dtos
{
    public abstract class GetAllForLookupTableInputBase : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}