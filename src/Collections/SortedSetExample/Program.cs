using Collections.Core;
using SortedSetExample;

Console.WriteLine("Hello, SortedSet!");

EventManagerTest();

static void EventManagerTest()
{
    EventManager eventManager = new EventManager();

    eventManager.AddEvent(new Event("E1", "Conference", DateTime.Parse("2023-12-15 09:00:00")));
    eventManager.AddEvent(new Event("E2", "Workshop", DateTime.Parse("2023-12-10 14:30:00")));
    eventManager.AddEvent(new Event("E3", "Networking Event", DateTime.Parse("2023-12-12 18:00:00")));

    var upcomingEvents = eventManager.GetUpcomingEvents();

    upcomingEvents.Dump("Upcoming Events:");
}

