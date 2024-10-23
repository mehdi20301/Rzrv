using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace RZRV.Web.Authentication.JwtBearer
{
    public class AsyncJwtBearerOptions : JwtBearerOptions
    {
        public readonly List<IAsyncSecurityTokenValidator> AsyncSecurityTokenValidators;
        
        private readonly RZRVAsyncJwtSecurityTokenHandler _defaultAsyncHandler = new RZRVAsyncJwtSecurityTokenHandler();

        public AsyncJwtBearerOptions()
        {
            AsyncSecurityTokenValidators = new List<IAsyncSecurityTokenValidator>() {_defaultAsyncHandler};
        }
    }

}
