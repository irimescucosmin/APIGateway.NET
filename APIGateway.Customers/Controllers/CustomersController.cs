using Microsoft.AspNetCore.Mvc;

namespace APIGateway.Customers.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class CustomersController : ControllerBase
{
    private static readonly List<string> _customers = ["Cst1", "Cst2", "Cst3"];

    [HttpGet]
    public Task<IActionResult> All()
    {
        return Task.FromResult<IActionResult>(Ok(_customers));
    }

    [HttpPost]
    public Task<IActionResult> Create([FromQuery] string customer)
    {
        const string HeaderKeyName = "X-Added-Website";
        Request.Headers.TryGetValue(HeaderKeyName, out var headerValue);
        _customers.Add(customer);
        return Task.FromResult<IActionResult>(Ok(new
        {
            Customers = _customers,
            CustomHeader = headerValue
        }));
    }
}