using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Lab_OWIN
{
    public class Startup
    {
        public void Configuration(IAppBuilder builder)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new { Id = RouteParameter.Optional });

            //builder.Run(context =>
            //{
            //    var sQuery = context.Request.QueryString.Value;
            //    context.Response.ContentType = "text/plain";
            //    return context.Response.WriteAsync(sQuery);
            //});

            builder.UseWebApi(config);
        }
    }
}
