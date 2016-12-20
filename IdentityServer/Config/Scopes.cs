using System.Collections.Generic;
using IdentityServer3.Core.Models;

namespace IdentityServer.Config
{
    public static class Scopes
    {
        public static List<Scope> Get()
        {
            return new List<Scope>
            {
                StandardScopes.OpenId,
                StandardScopes.Profile
            };
        }
    }
}