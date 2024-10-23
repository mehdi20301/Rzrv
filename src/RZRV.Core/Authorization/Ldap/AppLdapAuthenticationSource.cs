using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using RZRV.Authorization.Users;
using RZRV.MultiTenancy;

namespace RZRV.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}