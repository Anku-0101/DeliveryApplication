using FoodDeliveryApplication.DeliveryService;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgentController : ControllerBase
    {
        private readonly IDeliveryService _service;

        public AgentController(IDeliveryService service)
        {
            _service = service;

        }

        [HttpGet("agents")]
        public IActionResult GetAgents()
        {
            var agents = _service.GetAgents();
            foreach (var agent in agents)
            {
                Console.WriteLine($"Agent {agent.Id} at ({agent.X}, {agent.Y}) - Busy: {agent.Busy}");
            }
            return Ok(agents);
        }

        [HttpPost("move")]
        public IActionResult MoveAgents()
        {
            var agents = _service.MoveAgents();
            Console.WriteLine("Moved all agents");
            return Ok(agents);
        }
    }
}
