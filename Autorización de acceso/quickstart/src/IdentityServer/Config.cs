// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new IdentityResource[]
            {
                new IdentityResources.OpenId()
            };
        }

        public static IEnumerable<ApiResource> GetApis()
        {
            return new List<ApiResource>
                {
                    new ApiResource("APIDemo", "My API Demo"),
                };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {

                    new Client
                    {
                        ClientId = "client1",
                        AllowedGrantTypes = GrantTypes.ClientCredentials,
                         ClientSecrets ={new Secret("xxx".Sha256())},
                        AllowedScopes = { "APIDemo" }
                    },
                      new Client
                    {
                        ClientId = "client2",
                        AllowedGrantTypes = GrantTypes.ClientCredentials,
                        ClientSecrets ={new Secret("yyy".Sha256())},
                        AllowedScopes = { "APIDemostracion" }
                    }

                };
            }
    }
}