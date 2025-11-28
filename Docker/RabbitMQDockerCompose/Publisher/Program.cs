using RabbitMQ.Client;
using System.Text;

string queueName = "demo-queue";

var factory = new ConnectionFactory
{
    HostName = Environment.GetEnvironmentVariable("RABBITMQ_HOST") ?? "localhost",
    UserName = Environment.GetEnvironmentVariable("RABBITMQ_USER") ?? "guest",
    Password = Environment.GetEnvironmentVariable("RABBITMQ_PASS") ?? "guest"
};

var connection = await factory.CreateConnectionAsync();
var channel = await connection.CreateChannelAsync();

await channel.QueueDeclareAsync(
    queue: queueName,
    durable: true,
    exclusive: false,
    autoDelete: false,
    arguments: null
);

Console.WriteLine("Publisher started. Sending 10 test messages...");

for (int i = 1; i <= 10; i++)
{
    string bodyStr = $"Message #{i}";
    byte[] body = Encoding.UTF8.GetBytes(bodyStr);

    var props = new BasicProperties { Persistent = true };

    await channel.BasicPublishAsync(
        exchange: "",
        routingKey: queueName,
        mandatory: false,
        basicProperties: props,
        body: body
    );

    Console.WriteLine($"Sent: {bodyStr}");
    await Task.Delay(200);
}

Console.WriteLine("Publisher done.\n");

await channel.CloseAsync();
await connection.CloseAsync();
