using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace DanilaWebApp.Models
{
    public class Profile
    {
        public int Id { get; set; }
        
      
        public string Name { get; set; }
      
        public int Age { get; set; }
        
        public int UserId { get; set; }
        
        public User User { get; set; }
        
        public Order Order { get; set; }
    }
}