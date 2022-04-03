

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

        
            var reply = client.GetPeople(new RequestModel());

            Person[] persons = reply.Person.ToArray();


            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i]);
            }
            
        
    }
}