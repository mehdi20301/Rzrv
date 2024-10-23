using System.Collections.Generic;
using RZRV.Editions.Dto;

namespace RZRV.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}