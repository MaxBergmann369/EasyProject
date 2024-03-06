using EasyProjectAPI;

var builder = WebApplication.CreateBuilder(args);

// Add controllers to the service collection
builder.Services.AddControllers();

Setup.BuilderSetup(builder, "CorsPolicy");

var app = builder.Build();

Setup.SetUpEnvironment(app);

app.MapControllers();

app.Run();