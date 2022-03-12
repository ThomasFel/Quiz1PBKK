using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Quiz1PBKK.Models;

namespace Quiz1PBKK.Controllers;

public class Q1Controller : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Profile()
    {
        return View();
    }
    public IActionResult Company()
    {
        return View();
    }
    public IActionResult Product()
    {
        return View();
    }
    public IActionResult Collaboration()
    {
        return View();
    }
}
