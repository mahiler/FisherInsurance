using System;
using FisherInsurance.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeInsuranceController : Controller
{
    public IActionResult Index()
    {
        //return Ok("This is the index of the HomeInsuranceController");
        return View();
    }

    public IActionResult Quote()
    {
        //return Ok("This is your home insurance quote");
        Quote quote = new Quote
        {
            Id = 345,
            Product = "Home Insurance",
            ExpireDate = DateTime.Now.AddDays(45),
            Price = 45.00M
        };
        return View(quote);
    }
}