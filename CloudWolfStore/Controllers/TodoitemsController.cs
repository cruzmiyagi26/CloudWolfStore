using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CloudWolfStore.Models;
using CloudWolfStore.Data;

namespace CloudWolfStore.Controllers;

public class TodoitemsController : Controller
{
    private ApplicationDbContext _db;

    public TodoitemsController(ApplicationDbContext db)
    {
        _db = db;

    }

    public IActionResult Index()
    {
        var items = _db.TodoItems.ToList();
        return View(items);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateItem(TodoItem todoitem)
    {
        _db.TodoItems.Add(todoitem);
        _db.SaveChanges();

        return RedirectToAction("Index");
    }
}