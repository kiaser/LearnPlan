using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace RazorPages
{
    public static class BuilderExtensions
    {
        public static IApplicationBuilder UseElapsedTimeMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ElapsedTimeMiddleware>();
        }
    }
}
