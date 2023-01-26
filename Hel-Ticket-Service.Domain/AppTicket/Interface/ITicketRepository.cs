namespace Hel_Ticket_Service.Domain;

public interface ITicketRepository{

    #region Database
    Task<string> CreateTicket(CreateTicketDto ticket);
    Task<string> UpdateTicket(string reference, UpdateTicketDto ticket);
    Task<string> DeleteTicket(string reference);
    Task<Ticket> GetTicketByReference(string reference);
    Task<List<Ticket>> GetTicketByCategoryReference(string categoryference, int page);
    //Task<List<Ticket>> GetTicketList(string name,int page);
    Task<List<Ticket>> SearchTicketList(string name,  int page);
    
    #endregion
}

