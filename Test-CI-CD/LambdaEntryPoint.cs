using Amazon.Lambda.AspNetCoreServer;
using Test_CI_CD.Interfaces;
using Test_CI_CD.Services;

namespace Test_CI_CD
{
    public class LambdaEntryPoint : APIGatewayProxyFunction
    {
        protected override void Init(IWebHostBuilder builder)
        {
            builder.UseStartup<StartupWrapper>();
        }

        public class StartupWrapper
        {
            public void ConfigureServices(IServiceCollection services)
            {
                var builder = WebApplication.CreateBuilder();

                // Copiamos servicios del Program.cs
                services.AddControllers();
                services.AddEndpointsApiExplorer();
                services.AddSwaggerGen();
                services.AddScoped<IOperationService, OperationService>();
            }

            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                var builder = WebApplication.CreateBuilder();
                var webApp = builder.Build();

                webApp.UseSwagger();
                webApp.UseSwaggerUI();
                webApp.UseHttpsRedirection();
                webApp.UseAuthorization();
                webApp.MapControllers();

                webApp.Run();
            }
        }
    }
}
