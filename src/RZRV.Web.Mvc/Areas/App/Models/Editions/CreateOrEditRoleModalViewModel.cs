﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using RZRV.Editions.Dto;
using RZRV.Web.Areas.App.Models.Common;

namespace RZRV.Web.Areas.App.Models.Editions
{
    [AutoMapFrom(typeof(GetEditionEditOutput))]
    public class CreateEditionModalViewModel : GetEditionEditOutput, IFeatureEditViewModel
    {
        public IReadOnlyList<ComboboxItemDto> EditionItems { get; set; }

        public IReadOnlyList<ComboboxItemDto> FreeEditionItems { get; set; }
    }
}