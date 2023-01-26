
using Microsoft.AspNetCore.Mvc;
using Hel_Ticket_Service.Domain;

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
     
    }

