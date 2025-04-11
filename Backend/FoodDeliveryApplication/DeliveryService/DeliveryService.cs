using FoodDeliveryApplication.Models;


namespace FoodDeliveryApplication.DeliveryService
{
    public class DeliveryService : IDeliveryService
    {
        private const int AgentCount = 100;
        private const double Speed = 2.0;
        private readonly List<Agent> agents = [];
        private readonly List<Order> orders = [];
        private readonly Random random = new();

        public DeliveryService()
        {
            for (int i = 0; i < AgentCount; i++)
                agents.Add(new Agent { Id = i });
        }

        public List<Agent> GetAgents() => agents;
        public List<Order> GetOrders() => orders;

        public Order GenerateOrder()
        {
            var order = new Order
            {
                Id = orders.Count + 1,
                FromX = RandomInCircle(),
                FromY = RandomInCircle(),
                ToX = RandomInCircle(),
                ToY = RandomInCircle(),
                CreatedAt = DateTime.UtcNow
            };

            var available = agents.Where(a => !a.Busy).ToList();
            if (available.Any())
            {
                var nearest = available.OrderBy(a => Distance(a.X, a.Y, order.FromX, order.FromY)).First();
                order.AssignedAgentId = nearest.Id;
                nearest.CurrentOrderId = order.Id;
                nearest.Busy = true;
            }

            orders.Add(order);
            return order;
        }

        public List<Agent> MoveAgents()
        {
            foreach (var agent in agents)
            {
                if (!agent.Busy || agent.CurrentOrderId == null) continue;

                var order = orders.First(o => o.Id == agent.CurrentOrderId);
                var (targetX, targetY) = order.PickedUp ? (order.ToX, order.ToY) : (order.FromX, order.FromY);

                double dx = targetX - agent.X;
                double dy = targetY - agent.Y;
                double dist = Math.Sqrt(dx * dx + dy * dy);

                if (dist <= Speed)
                {
                    agent.X = targetX;
                    agent.Y = targetY;

                    if (!order.PickedUp)
                        order.PickedUp = true;
                    else
                    {
                        agent.Busy = false;
                        agent.CurrentOrderId = null;
                    }
                }
                else
                {
                    agent.X += Speed * dx / dist;
                    agent.Y += Speed * dy / dist;
                }
            }

            return agents;
        }

        private double RandomInCircle()
        {
            double angle = random.NextDouble() * 2 * Math.PI;
            double radius = Math.Sqrt(random.NextDouble()) * 10;
            return radius * Math.Cos(angle);
        }

        private double Distance(double x1, double y1, double x2, double y2) =>
            Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
}
