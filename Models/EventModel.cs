using System;

namespace vediaiapi.Models
{
    public class EventModel
    {
       public int Id { get; set; }
       public int interviewee_id { get; set; }
       public int interviewer_id { get; set; }
       public string event_url { get; set; }
       public DateTime date { get; set; }
    }
}