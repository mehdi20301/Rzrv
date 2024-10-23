using System.Collections.Generic;
using Abp.Localization;
using RZRV.Install.Dto;

namespace RZRV.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
