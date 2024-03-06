namespace EasyProjectAPI;

public class Setup
{
	public static void BuilderSetup(WebApplicationBuilder builder, string policy)
	{
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();
		builder.Services.AddSignalR();
		builder.Services.AddCors(options =>
		{
			options.AddPolicy(policy, b =>
			{
				b.AllowAnyOrigin()
					.AllowAnyMethod()
					.AllowAnyHeader();
			});
		});
	}

	public static void SetUpEnvironment(WebApplication app)
	{
		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}
	}
}

