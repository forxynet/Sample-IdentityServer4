﻿using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace Sample.IdentityServer4.Configuration
{
    public class Users
    {
        public static List<TestUser> Get() {
            return new List<TestUser>
        {
            new TestUser
            {
                SubjectId = "56892347",
                Username = "procoder",
                Password = "password",
                Claims = new List<Claim>
                {
                    new Claim(JwtClaimTypes.Email, "support@Sample.IdentityServer4.com"),
                    new Claim(JwtClaimTypes.Role, "admin"),
                    new Claim(JwtClaimTypes.WebSite, "https://Sample.IdentityServer4.com")
                }
            }
        };
        }
    }
}
