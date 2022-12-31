using vediaiapi.Models;
using vediaiapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace vediaiapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IntervieweeController : ControllerBase
{
    public IntervieweeController()
    {
    }
    // GET All action
    public ActionResult<List<IntervieweeAccountModel>> GetAll() => 
        IntervieweeService.GetAll();
 }