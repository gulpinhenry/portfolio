﻿using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Areas.Admin.Controllers;
[Area("Admin")]

public class ProjectsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Create()
    {
        return View();
    }
    public IActionResult Edit()
    {
        return View();
    }
    public IActionResult Delete()
    {
        return View();
    }
}
