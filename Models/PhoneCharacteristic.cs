using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DanilaWebApp.Models
{
    public class PhoneCharacteristic
    {
        public int Id { get; set; }
       
        public string type { get; set; }
     
        public string opSystem { get; set; }
     
     
        public string ScreenType { get; set; }
     
        public int PhoneWidth { get; set; }
       
        public int PhoneHeight { get; set; }
        
        public int PhoneDepth { get; set; }
       
        public string CpuModel { get; set; }
        
        public ICollection<SupportedCommunicationType> SupportedCommunicationTypes { get; set; }
        
        public Phone Phone { get; set; } 
    }
}