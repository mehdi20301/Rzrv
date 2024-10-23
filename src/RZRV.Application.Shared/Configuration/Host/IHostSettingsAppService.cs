﻿using System.Threading.Tasks;
using Abp.Application.Services;
using RZRV.Configuration.Host.Dto;

namespace RZRV.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
