using BaseballShop.Services;
using Microsoft.AspNetCore.Mvc;

[Route("api/mockpayment")]
[ApiController]
public class MockPaymentController : ControllerBase
{
    private readonly MockPaymentService _mockPaymentService;

    public MockPaymentController(MockPaymentService mockPaymentService)
    {
        _mockPaymentService = mockPaymentService;
    }

    [HttpPost("process")]
    public IActionResult ProcessPayment(decimal amount, string currency)
    {
        var result = _mockPaymentService.ProcessPayment(amount, currency);
        return Ok(new { Message = result });
    }
}