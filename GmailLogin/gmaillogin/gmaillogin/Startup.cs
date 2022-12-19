using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(gmaillogin.Startup))]

namespace gmaillogin
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);

            app.UseGoogleAuthentication(
       clientId: "335854588442-ead71v62b2o5ddh9ji35maae5aamtke9.apps.googleusercontent.com",
       clientSecret: "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");



        }
    }
}
