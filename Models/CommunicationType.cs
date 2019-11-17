using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DanilaWebApp.Models
{
    public class CommunicationType
    {
        public int Id { get; set; }
        
       
        public string CommunicationName { get; set; }
   
        public string CommunicationSubType { get; set; }
        
        public ICollection<SupportedCommunicationType> SupportedCommunicationTypes { get; set; }
    }
}