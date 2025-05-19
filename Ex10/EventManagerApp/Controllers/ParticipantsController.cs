using Microsoft.AspNetCore.Mvc;
using EventManagerApp.Data;
using EventManagerApp.Models;

namespace EventManagerApp.Controllers;

public class ParticipantsController : Controller
{
    public IActionResult Create(int eventId)
    {
        ViewBag.EventId = eventId;
        return View();
    }

    [HttpPost]
    public IActionResult Create(Participant participant)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.EventId = participant.EventId;
            return View(participant);
        }

        participant.Id = InMemoryDatabase.NextParticipantId++;
        InMemoryDatabase.Participants.Add(participant);
        return RedirectToAction("ListByEvent", new { eventId = participant.EventId });
    }

    public IActionResult ListByEvent(int eventId)
    {
        var eventItem = InMemoryDatabase.Events.Find(e => e.Id == eventId);
        if (eventItem == null) return NotFound();
        
        var participants = InMemoryDatabase.Participants
            .Where(p => p.EventId == eventId)
            .ToList();

        ViewBag.EventTitle = eventItem.Title;
        return View(participants);
    }
}