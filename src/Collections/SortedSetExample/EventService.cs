﻿namespace SortedSetExample;

internal class EventManager
{
    private readonly SortedSet<Event> _upcomingEvents = new SortedSet<Event>(new EventComparer());

    public void AddEvent(Event newEvent)
    {
        _upcomingEvents.Add(newEvent);
        Console.WriteLine($"Added event: {newEvent}");
    }

    public IEnumerable<Event> GetUpcomingEvents()
    {
        return _upcomingEvents;
    }

    public IEnumerable<Event> GetUpcomingEvents(DateTime to)
    {
        return _upcomingEvents.Where(@event => @event.StartTime.Date < to.Date);
    }
}

class EventComparer : IComparer<Event>
{
    public int Compare(Event? x, Event? y)
    {
        return x.StartTime.CompareTo(y.StartTime);
    }
}

class Event
{
    public string EventId { get; }
    public string Title { get; }
    public DateTime StartTime { get; }

    public Event(string eventId, string title, DateTime startTime)
    {
        EventId = eventId;
        Title = title;
        StartTime = startTime;
    }

    public override string ToString()
    {
        return $"{Title} (Event ID: {EventId}), Start Time: {StartTime:yyyy-MM-dd HH:mm:ss}";
    }
}