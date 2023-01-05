using vediaiapi.Models;

namespace vediaiapi.Services;

public static class EventService
{
    static List<EventModel> Events { get; }
    static int nextId = 3;

    static EventService()
    {
        DateTime date1 = new DateTime(2023, 6, 1, 7, 47, 0);
        DateTime date2 = new DateTime(2023, 7, 1, 8, 47, 0);
        Events = new List<EventModel>
        {
            new EventModel {Id = 1, interviewee_id = 1, interviewer_id = 1, event_url = "sdgasgdfsgas", date = date1, },
            new EventModel {Id = 2, interviewee_id = 1, interviewer_id = 2, event_url = "sdgasgdfsgas", date = date2, }
        }; 
    }

    public static List<EventModel> GetAll() => Events;
}