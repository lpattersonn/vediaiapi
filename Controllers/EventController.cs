using vediaiapi.Models;
using vediaiapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace vediaiapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventController : ControllerBase
{
    public EventController()
    {
    }
    // Get all events
    public ActionResult<List<EventModel>> GetAll() =>
    EventService.GetAll();
}