using RabbitMQ.Client;
using RabbitMQ.Client.Events;
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

await channel.QueueDeclareAsync(queueName, true, false, false, null);

await channel.BasicQosAsync(0, 1, false);

var consumer = new AsyncEventingBasicConsumer(channel);

consumer.ReceivedAsync += async (sender, ea) =>
{
    string message = Encoding.UTF8.GetString(ea.Body.ToArray());
    Console.WriteLine($"[Received] {message}");

    await Task.Delay(300);

    await channel.BasicAckAsync(ea.DeliveryTag, multiple: false);
};

await channel.BasicConsumeAsync(queue: queueName, autoAck: false, consumer);

Console.WriteLine("Subscriber listening... Ctrl + C to quit.");
await Task.Delay(-1);
