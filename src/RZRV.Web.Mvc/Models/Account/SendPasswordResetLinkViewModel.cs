using System.ComponentModel.DataAnnotations;

namespace RZRV.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}