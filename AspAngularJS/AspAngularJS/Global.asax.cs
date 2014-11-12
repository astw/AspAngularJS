using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Newtonsoft.Json;
using System.Web.Routing;

namespace AspAngularJS
{
    using System.Threading;

    using Google.Apis.Auth.OAuth2;
    using Google.Apis.Drive.v2;
    using Google.Apis.Util.Store;

    using Newtonsoft.Json.Serialization;

    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);

            ConfigureApi(GlobalConfiguration.Configuration);

           // GetPermisssion();
        }


        private void GetPermisssion()
        {
            UserCredential credential;
            credential =
                GoogleWebAuthorizationBroker.AuthorizeAsync(
                    new ClientSecrets
                    {
                        ClientId = "1089632013491-1ap1gckvhagh3sjtvh705j6dag9j3ko2.apps.googleusercontent.com",
                        ClientSecret = "J_RyGmZshVR_1Tx6Yi3dUW84"
                    },
                    new[]
                        {
                            DriveService.Scope.Drive, 
                            DriveService.Scope.DriveFile
                        },
                    "wshuhao@gmail.com",
                    CancellationToken.None,
                    new FileDataStore("Drive.Auth.Store")).Result;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        private static void RegisterRoutes(RouteCollection routeCollection)
        {
            routeCollection.MapHttpRoute(
                name: "EventsApi",
                routeTemplate: "v1/events",
                defaults: new { controller = "Events", action = "Get" });
            
            routeCollection.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "v1/{controller}/{id}",
                defaults: new { id = System.Web.Http.RouteParameter.Optional });
        }

        private static void ConfigureApi(HttpConfiguration configuration)
        {
            ConfigureFormatters(configuration);
        }

        private static void ConfigureFormatters(HttpConfiguration configuration)
        {
            configuration.Formatters.JsonFormatter.SerializerSettings.DefaultValueHandling = DefaultValueHandling.Include;
            configuration.Formatters.XmlFormatter.UseXmlSerializer = true;
            configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(new QueryStringMapping("format", "json", "application/json"));
            configuration.Formatters.XmlFormatter.MediaTypeMappings.Add(new QueryStringMapping("format", "xml", "application/xml"));

            var formatters = configuration.Formatters;  // GlobalConfiguration.Configuration.Formatters;
            var jsonFormatter = formatters.JsonFormatter;
            var settings = jsonFormatter.SerializerSettings;
            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}