using System.Web.Http;
using WebActivatorEx;
using SimpleDbViewer;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace SimpleDbViewer
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c => c.SingleApiVersion("0", "Simple Database Viewer"))
                .EnableSwaggerUi();
        }
    }
}
