using Microsoft.AspNetCore.Builder;

namespace Odevv
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //MVC Service
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            // https://localhost:5001/Home/Index
            //Controller: Home
            //Method: Index
        }
    }
}
