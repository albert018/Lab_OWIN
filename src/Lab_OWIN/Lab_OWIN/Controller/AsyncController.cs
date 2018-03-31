using System.Threading.Tasks;
using System.Web.Http;
using System.Net.Http;
using System.Diagnostics;
using System.Net;
using Owin;

namespace Lab_OWIN.Controller
{
    public class AsyncController : ApiController
    {
        
        [HttpGet]
        public async Task<HttpResponseMessage> FirstCall()
        {
            var sw = Stopwatch.StartNew();
            string result = await Task.Run<string>(() =>
            {
                return "inside method";
            });
            sw.Stop();
            return Request.CreateResponse(HttpStatusCode.OK,
                new
                {
                    Message = result,
                    Time = sw.ElapsedMilliseconds
                });
        }
    }
}
