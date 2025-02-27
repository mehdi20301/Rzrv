﻿using System.Collections.Generic;
using RZRV.DynamicEntityProperties.Dto;

namespace RZRV.Web.Areas.App.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
