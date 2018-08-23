using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace hosting
{
    public class Middleware
    {
        private RequestDelegate _next;

        public Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context){
            
            await _next(context);
        }
    }
}