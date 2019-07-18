using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace bProject_ASPNET
{
    public class Startup
    {
        private IConfiguration _config;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940


        public Startup(IConfiguration config)
        {
            _config = config;

        }

        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //middleware go here?
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions devOptions = new DeveloperExceptionPageOptions
                {
                    SourceCodeLineCount = 10
                };
                app.UseDeveloperExceptionPage(devOptions);
            }

            // There is a better way to do this
            /*  
            DefaultFilesOptions defaultFileOptions = new DefaultFilesOptions();
            defaultFileOptions.DefaultFileNames.Clear();
            defaultFileOptions.DefaultFileNames.Add("foo.html");
            

            // https://csharp-video-tutorials.blogspot.com/2019/01/static-files-in-aspnet-core.html
            // rewrite root url to default file url, but the client sees the root url on browser 
            app.UseDefaultFiles(defaultFileOptions);

            // Static file middleware, serves static files located in wwwroot folder according to file path and names
            app.UseStaticFiles();
            */

            FileServerOptions fileserveroptions = new FileServerOptions();
            fileserveroptions.DefaultFilesOptions.DefaultFileNames.Clear();
            fileserveroptions.DefaultFilesOptions.DefaultFileNames.Add("foo.html");
            app.UseFileServer(fileserveroptions);

            app.Run(async (context) =>
            {
                throw new Exception("Some error occured");
                await context.Response.WriteAsync("Hello");
            });
        }
    }
}
