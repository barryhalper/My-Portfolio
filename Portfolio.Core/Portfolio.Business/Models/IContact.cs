using System;

namespace Portfolio.Business.Models
{ 
    public interface IContact
    {
        string Email { get; set; }
        string Message { get; set; }
        string Name { get; set; }


    }
}