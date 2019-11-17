using System.ComponentModel.DataAnnotations;

namespace DanilaWebApp.Models
{
    public class Phone
    {
        public int Id { get; set; }
       
        public string Company { get; set; }
       
        public int Price { get; set; }
        
        public PhoneCharacteristic Characteristic { get; set; }
        
        public int CharacteristicId { get; set; }

        public Order Order { get; set; }
        
        public int OrderId { get; set; }
    }
}