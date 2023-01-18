using Microsoft.AspNetCore.Builder;

namespace Odev
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

            //MVC Route
            app.UseEndpoints(x =>
            {
                x.MapDefaultControllerRoute();
            });

            // https://localhost:5001/Controller/Method

            //Controller: Home
            //Method: Index

        }
    }
}
