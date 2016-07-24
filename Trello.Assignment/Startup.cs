using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Trello.Assignment
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            var routerBuilder = new RouteBuilder(app);
            routerBuilder.MapGet("", IndexHandler.Get);
            routerBuilder.MapGet("assign", AssignHandler.Get);
            routerBuilder.MapPost("assign/{id}", AssignHandler.Post);

            app.UseRouter(routerBuilder.Build());
        }
    }
}
