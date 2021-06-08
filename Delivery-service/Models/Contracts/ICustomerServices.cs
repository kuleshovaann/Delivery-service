using DeliveryService.Models;

namespace DeliveryService.Contracts
{
    public interface ICustomerServices
    {
        Order MakeOrder(Company restraunt, Customer customer);
    }
}
