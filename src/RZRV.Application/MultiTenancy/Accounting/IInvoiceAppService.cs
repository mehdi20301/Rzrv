using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using RZRV.MultiTenancy.Accounting.Dto;

namespace RZRV.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
