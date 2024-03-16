using GymManagement.Contracts.api.requests.Subscriptions;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api;

[ApiController]
[Route("api/[controller]")]
public class SubscriptionsController : ControllerBase
{
    [HttpPost()]
    public IActionResult CreateSubscription([FromBody] CreateSubscriptionRequest request)
    {
        return Ok(request);
    }   
}
