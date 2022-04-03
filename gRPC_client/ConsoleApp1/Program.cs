

using ConsoleApp1;
using Grpc.Net.Client;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("press any");
        Console.ReadLine();
        using var channel = GrpcChannel.ForAddress("http://localhost:5122");
        var client = new Customer.CustomerClient(channel);

        for (int i = 0; i <= 2; i++)
        {
            var clientRequested = new CustomerLookupModel
            {
                UserId = i
            };
            var reply = client.GetCustomerInfoAsync(clientRequested).ResponseAsync;
            Console.WriteLine($"{reply.Result.FirstName}, {reply.Result.LastName}");
        }
        
        
        
    }
}