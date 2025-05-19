using Microsoft.AspNetCore.Mvc;
using EventManagerApp.Data;
using EventManagerApp.Models;

namespace EventManagerApp.Controllers;
public class EventsController : Controller
{
    public IActionResult Index()
    {
        return View(InMemoryDatabase.Events);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost] 
    public IActionResult Create(Event eventModel)
    {
        if (!ModelState.IsValid)
        {
            return View(eventModel);
        }

        eventModel.Id = InMemoryDatabase.NextEventId++;
        InMemoryDatabase.Events.Add(eventModel);
        return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
        var eventItem = InMemoryDatabase.Events.Find(e => e.Id == id);
        if (eventItem == null)
        {
            return NotFound();
        }
        return View(eventItem);
    }
}