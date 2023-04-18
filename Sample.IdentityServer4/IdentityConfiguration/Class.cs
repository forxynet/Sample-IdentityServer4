using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;
using System.Security;

namespace Sample.IdentityServer4.IdentityConfiguration
{
    public class Class
    {
        public static IEnumerable<Client> Get(){
            return new List<Client> {
                new Client {
                    ClientId = "weatherApi",
                    ClientName = "ASP.NET Core Weather Api",
                    AllowedGrantTypes = new GrantTypes.ClientCredentials,
                    ClientScre
                }
            }
        }
    }
}
