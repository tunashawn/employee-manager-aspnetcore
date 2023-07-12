﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using employee_manager_aspnetcore.Models;
using Microsoft.AspNetCore.Authorization;

namespace employee_manager_aspnetcore.Controllers;

[Authorize]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Privacy()
    {
        return View();
    }
    
    [Authorize(Roles = "Admin")]
    public IActionResult Roles()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}