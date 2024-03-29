﻿
using System.Reflection;

namespace Payment.Api
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen(options =>
			{
				options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
				{
					Version = "v1",
					Title = "Payment Services Api",
					Description = "Demo tính năng thanh toán bằng API",
					Contact = new Microsoft.OpenApi.Models.OpenApiContact()
					{
						Name = "Nguyen Gia Bao",
					}
				});
				var xmlFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				var path = Path.Combine(AppContext.BaseDirectory, xmlFileName);
				options.IncludeXmlComments(path);
			});

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}