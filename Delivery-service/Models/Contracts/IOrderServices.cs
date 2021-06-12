using DeliveryService.Models;

namespace DeliveryService.Contracts
{
    public interface IOrderServices
    {
        void AddToOrder(Company company, Order order, int index);

        void AddToDataBase(Order order);
    }
}
