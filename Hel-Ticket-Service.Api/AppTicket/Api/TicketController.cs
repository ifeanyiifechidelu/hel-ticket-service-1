
using Microsoft.AspNetCore.Mvc;
using Hel_Ticket_Service.Domain;
using Hel_Ticket_Service.Domain.AppTicket.Contract;

namespace Hel_Ticket_Service.Api;
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        readonly ITicketRepository _ticketRepository ;
        readonly ITicketService _ticketService;
        public TicketController(ITicketRepository ticketRepository, ITicketService ticketService) {
            _ticketRepository = ticketRepository;
            _ticketService    = ticketService;
        }
        [HttpPost]
        public async Task<ActionResult<string>> CreateTicket([FromBody] CreateTicketDto createTicketDto)
        {
                return Ok (await _ticketRepository.CreateTicket(createTicketDto));
        }
        [HttpPut("{reference}")]
        public async Task<ActionResult<string>> UpdateTicket(string reference,[FromBody] UpdateTicketDto updateTicketDto)
        {

                return Ok(await _ticketRepository.UpdateTicket(reference,updateTicketDto));

        }
        [HttpDelete("{reference}")]
        public async Task<ActionResult<string?>> DeleteTicket(string reference)
        {

                return Ok(await _ticketRepository.DeleteTicket(reference));
  
        }
        [HttpGet("reference/{reference}")]
        public async Task<ActionResult<Ticket>> GetTicketByReference(string reference)
        {
  
                return Ok( await _ticketRepository.GetTicketByReference(reference));
           
        }
        [HttpGet("category/{page:int:min(1)}")]
        public async Task<ActionResult<Ticket>> GetTicketByCategoryReference(string categoryreference, int page)
        {
  
                return Ok( await _ticketRepository.GetTicketByCategoryReference(categoryreference, page));
           
        }

        [HttpGet("search/{page:int:min(1)}")]
        public async Task<ActionResult<List<Ticket>>> SearchTicketList(string name, int page)
        {
                return Ok( await _ticketRepository.SearchTicketList(name, page));
          
        }

        [HttpGet("summary")]
        public async Task<ActionResult<TicketsSummaryDto>> GetTicketsSummary()
        {
            var result = await _ticketRepository.GetTicketsSummary();

            return Ok(result);
        }

        [HttpGet("user/{page:int:min(1)}")]
        public async Task<ActionResult<Ticket>> GetEscalatedTicketsByUser(string user, int page)
        {
            var result = await _ticketRepository.GetEscalatedTicketsByUser(user, page);

            return Ok(result);
        }

        [HttpGet("admin/{page:int:min(1)}")]
        public async Task<ActionResult<Ticket>> GetEscalatedTicketsToAdmin(string admin, int page)
        {
            var result = await _ticketRepository.GetEscalatedTicketsByUser(admin, page);

            return Ok(result);
        }
    }

