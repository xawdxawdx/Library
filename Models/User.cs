using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DanilaWebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        
        
        public string Login { get; set; }
        
        
        public string Password { get; set; }
        
       
        public DateTime RegistrationDate { get; set; }
        public Profile Profile { get; set; }
       
    }
}