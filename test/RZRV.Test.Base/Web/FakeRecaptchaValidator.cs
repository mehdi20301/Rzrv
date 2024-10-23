using System.Threading.Tasks;
using RZRV.Security.Recaptcha;

namespace RZRV.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
