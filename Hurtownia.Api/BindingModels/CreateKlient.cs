using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Hurtownia.Data.DAO;

namespace Hurtownia.Api.BindingModels
{
    public class CreateKlient
    {
        [Required]
        [Display(Name = "Imie")]
        public string Imie { get; set; }
        
        [Required]
        [Display(Name = "Nazwisko")]
        public string Nazwisko { get; set; }
        
        
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        
        [Display(Name = "NrTel")]
        public string NrTel { get; set; }
        
        [Required]
        [Display(Name = "Adres")]
        public Adres Adres { get; set; }


    }
}