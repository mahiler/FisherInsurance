using Microsoft.AspNetCore.Mvc;

public class HomeInsuranceController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the HomeInsuranceController");
    }

    public IActionResult Quote()
    {
        return Ok("This is your home insurance quote");
    }
}