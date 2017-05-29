﻿using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using TG.UBP.Authorization.Users;
using TG.UBP.MultiTenancy;

namespace TG.UBP.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
