﻿using System.ComponentModel.DataAnnotations;

namespace RZRV.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}