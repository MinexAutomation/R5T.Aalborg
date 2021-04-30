using System;
using System.Net;


namespace R5T.Aalborg.Extensions
{
    public static class IAuthenticationExtensions
    {
        public static NetworkCredential GetNetworkCredential(this IAuthentication authentication)
        {
            var networkCredential = new NetworkCredential(authentication.Username, authentication.Password);
            return networkCredential;
        }
    }
}
