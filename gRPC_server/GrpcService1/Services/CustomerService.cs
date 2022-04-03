using Grpc.Core;

namespace GrpcService1.Services;

public class CustomerService : Customer.CustomerBase
{
    private readonly ILogger<CustomerService> _logger;
    
    public CustomerService(ILogger<CustomerService> logger)
    {
        _logger = logger;
    }

    public override async Task<ReplyModel> GetPeople(RequestModel request, ServerCallContext context)
    {
        List<Person> people = new List<Person>() {
            new Person() { Id=1,FirstName="david",LastName="totti",Age=31},
            new Person() { Id=2,FirstName="lebron",LastName="maldini",Age=32},
            new Person() { Id=3,FirstName="leo",LastName="zidan",Age=33},
            new Person() { Id=4,FirstName="bob",LastName="messi",Age=34},
            new Person() { Id=5,FirstName="alex",LastName="ronaldo",Age=35},
            new Person() { Id=6,FirstName="frank",LastName="fabregas",Age=36}
        };
        ReplyModel replyModel = new ReplyModel();
        replyModel.Person.AddRange(people);
        return replyModel;
    }
}

