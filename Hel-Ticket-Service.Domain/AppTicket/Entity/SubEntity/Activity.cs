using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
namespace Hel_Ticket_Service.Domain.AppTicket.Entity.SubEntity
{
    public class Activity
    {
       
      [BsonId]
      public string Reference { get; set; }
      public string Message { get; set; } 
      public DateTime  CompletionTime { get; set; } 
      public string Status {get; internal set; } 
      
    
    }
}