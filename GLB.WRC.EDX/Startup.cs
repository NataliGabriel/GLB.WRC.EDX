using GLB.WRC.EDX.Repos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GLB.WRC.EDX
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ConexaoBanco>();
        }
    }
}
