using System.ComponentModel.DataAnnotations;

namespace DanilaWebApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        
        public string Country { get; set; }

        public string City { get; set; }
     
        public string AdditionalLocation { get; set; }
        
      
        public string ZipCode { get; set; }
        
        public bool SelfExport { get; set; }

        public Order Order { get; set; }
    }
}