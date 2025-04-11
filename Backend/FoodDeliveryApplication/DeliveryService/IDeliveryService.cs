using FoodDeliveryApplication.Models;

namespace FoodDeliveryApplication.DeliveryService
{
    public interface IDeliveryService
    {
        List<Agent> GetAgents();
        List<Order> GetOrders();
        Order GenerateOrder();
        List<Agent> MoveAgents();
    }
}
