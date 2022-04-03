using Grpc.Core;

namespace GrpcService1.Services;

public class CustomerService : Customer.CustomerBase
{
    private readonly ILogger<CustomerService> _logger;
    
    public CustomerService(ILogger<CustomerService> logger)
    {
        _logger = logger;
    }

    public override Task<CustomerModel> GetCustomerInfo(CustomerLookupModel request, ServerCallContext context)
    {
        CustomerModel output = new CustomerModel();

        if (request.UserId == 1)
        {
            output.FirstName = "Jamie";
            output.LastName = "Smith";
        }
        else if (request.UserId == 2)
        {
            output.FirstName = "Jamie2";
            output.LastName = "Smith2";
        }
        else
        {
            output.FirstName = "none";
            output.LastName = "none";
        }

        return Task.FromResult(output);
    }
}