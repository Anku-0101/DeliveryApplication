namespace FoodDeliveryApplication.Models
{
    public class Order
    {
        public int Id { get; set; }
        public double FromX { get; set; }
        public double FromY { get; set; }
        public double ToX { get; set; }
        public double ToY { get; set; }
        public int? AssignedAgentId { get; set; }
        public bool PickedUp { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }
}
/*
 * Order generator -> generate order
 * 
 */