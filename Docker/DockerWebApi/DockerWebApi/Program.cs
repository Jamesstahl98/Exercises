namespace DockerWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container (include views because controllers inherit Controller).
            builder.Services.AddControllersWithViews();

            // Swagger/OpenAPI
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Show detailed errors in Development
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Configure the HTTP request pipeline.
            app.UseHttpsRedirection();

            // Enable Swagger UI and JSON endpoint
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "DockerWebApi v1");
                c.RoutePrefix = "swagger";
            });

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
