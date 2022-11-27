using Autofac;
using Autofac.Extensions.DependencyInjection;
using Backend.GameHubs;
using Backend.Utilities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Chess2Tests.IntegrationalHelpers;

public class TestStartup
{
    public IConfiguration Configuration { get; }
    public IHostingEnvironment Environment { get; }
    public IContainer ApplicationContainer { get; private set; }

    public TestStartup(IConfiguration configuration, IHostingEnvironment hostingEnvironment)
    {
        Configuration = configuration;
        Environment = hostingEnvironment;
    }

    public IServiceProvider ConfigureServices(IServiceCollection services)
    {
        services.AddMvc()
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

        services.AddSignalR(options => { options.EnableDetailedErrors = Environment.IsDevelopment(); });

        var containerBuilder = new ContainerBuilder();
        containerBuilder.Populate(services);
        ApplicationContainer = containerBuilder.Build();
        return new AutofacServiceProvider(ApplicationContainer);
    }
    
    public void Configure(IApplicationBuilder app,
        IApplicationLifetime applicationLifetime)
    {
        app.UseStaticFiles();
        app.UseRouting();
        
        app.UseAuthentication();
        app.UseWebSockets();

        app.UseEndpoints(route =>
        {
            route.MapHub<GameHub>("/game");
            route.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
        

        applicationLifetime.ApplicationStopped.Register(() => ApplicationContainer.Dispose());
    }
}