using RZRV.Modal.Dtos;

using Abp.Extensions;

namespace RZRV.Web.Areas.App.Models.Currencies
{
    public class CreateOrEditCurrencyViewModel
    {
        public CreateOrEditCurrencyDto Currency { get; set; }

        public bool IsEditMode => Currency.Id.HasValue;
    }
}