using Microsoft.EntityFrameworkCore;
using Serilog;
using WebApplication4;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

Log.Information("Starting up");

try
{
    var builder = WebApplication.CreateBuilder(args);
    builder.Host.UseSerilog();
    builder.Services.AddDbContext<TestContext>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(TestContext))));

    var app = builder.Build();

    app.Run();
}
catch (Exception ex)
{
    Log.Information(ex, "Exception");
}

Log.Information("Shut down complete");
//Log.CloseAndFlush();

