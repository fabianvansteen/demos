using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace MyCoolApp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app){
            app.Run(context => {
                return context.Response.WriteAsync("Hello world");
            });
        }
    }
}