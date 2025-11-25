namespace ServiceA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            var serviceBUrl = builder.Configuration["SERVICEB_URL"] ?? "http://serviceb";

            builder.Services.AddHttpClient("serviceBClient", client =>
            {
                client.BaseAddress = new Uri(serviceBUrl);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();

            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            app.MapGet("/weatherforecast", (HttpContext httpContext) =>
            {
                var forecast = Enumerable.Range(1, 5).Select(index =>
                    new WeatherForecast
                    {
                        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                        TemperatureC = Random.Shared.Next(-20, 55),
                        Summary = summaries[Random.Shared.Next(summaries.Length)]
                    })
                    .ToArray();
                return forecast;
            });

            app.MapGet("/", () => "ServiceA is running");

            app.MapGet("/call", async (IHttpClientFactory httpFactory) =>
            {
                var client = httpFactory.CreateClient("serviceBClient");
                var result = await client.GetStringAsync("/hello");
                return $"ServiceA -> {result}";
            });

            app.Run();
        }
    }
}
