using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace APIDemo
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
            {
                services.AddMvcCore()
                    .AddAuthorization()
                    .AddJsonFormatters();

                services.AddAuthentication("Bearer")
                    .AddJwtBearer("Bearer", options =>
                    {
                        options.Authority = "http://localhost:5000";
                        options.RequireHttpsMetadata = false;
                        options.Audience = "APIDemo";
                    });
            }

            public void Configure(IApplicationBuilder app)
            {
                app.UseAuthentication();

                app.UseMvc();
            }
        }
}
