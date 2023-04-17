
namespace Hel_Ticket_Service.Domain;

public abstract class EventBaseEto<T> where T : class
{
    public Guid EventID { get; set; }
    public DateTime EventDate { get; set; }
    public string EventType { get; set; }
    public string EventName { get; set; }
    public string EventDomain { get; set; }
    public string EventSource { get; set; }
    public T EventData { get; set; }
    public string EventMessage { get; set; }
    public string CorrelationID { get; set; }
    public string EventCategoryID { get; set; }
    public string EventObjectName { get; set; }
    public string EventObjectID { get; set; }

    public EventBaseEto(T eto, object eventObject, string eventObjectID, string eventType) 
    {
        EventID = Guid.NewGuid();
        EventDate = DateTime.Now;
        EventType = eventType;
        EventName = this.GetType().Name.Replace("Eto", "Event");
        EventSource = Service.Name;
        EventDomain = eto.GetType().Namespace;
        EventData = eto;
        CorrelationID = "correlationID";
        EventCategoryID = "eventCategoryID";
        EventObjectName = eventObject.GetType().Name;
        EventObjectID = eventObjectID;
        EventMessage = $"{EventObjectName} with ID: {EventObjectID} was {EventType} on {EventDate} by Category with ID: {EventCategoryID}";
    }
}
