﻿using System.ComponentModel.DataAnnotations;

namespace RZRV.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
