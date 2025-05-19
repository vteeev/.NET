using EventManagerApp.Models;

namespace EventManagerApp.Data;

public static class InMemoryDatabase
{
    public static List<Event> Events { get; } = new();
    public static List<Participant> Participants { get; } = new();
    
    public static int NextEventId { get; set; } = 1;
    public static int NextParticipantId { get; set; } = 1;
}