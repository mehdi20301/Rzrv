﻿using Abp.AutoMapper;
using RZRV.MultiTenancy.Dto;

namespace RZRV.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}