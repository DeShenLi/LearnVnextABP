using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace VnextProject
{
    public class VnextProjectWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<VnextProjectWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}