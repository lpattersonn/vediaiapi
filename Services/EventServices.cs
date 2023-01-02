using vediaiapi.Models;

namespace vediaiapi.Services;

public static class EventService
{
    static List<EventModel> Events { get; }
    static int nextId = 3;
    static EventService()
    {
        Events = new List<EventModel>
        {
            new EventModel {Id = 1, interviewee_id = 1, interviewer_id = 1, event_url = "sdgasgdfsgas"},
            new EventModel {Id = 2, interviewee_id = 1, interviewer_id = 2, event_url = "sdgasgdfsgas"}
        };
    }

    public static List<EventModel> GetAll() => Events;
}