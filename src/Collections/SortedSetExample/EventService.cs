using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSetExample;

internal class EventManager
{
    public void AddEvent(Event newEvent)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Event> GetUpcomingEvents()
    {
        throw new NotImplementedException();
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