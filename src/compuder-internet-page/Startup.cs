using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace compuder_internet_page
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) { }

        public void Configure(IApplicationBuilder app)
        {
            DefaultFilesOptions options = new DefaultFilesOptions();
            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("html/index.html");
            app.UseDefaultFiles(options);
            app.UseStaticFiles();
        }
    }
}
