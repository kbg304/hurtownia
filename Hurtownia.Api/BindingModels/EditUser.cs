using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Hurtownia.Data.DAO;

namespace Hurtownia.Api.BindingModels
{
    public class EditUser
    {
    
        [Display(Name = "Imie")]
        public string Imie { get; set; }
        

        [Display(Name = "Nazwisko")]
        public string Nazwisko { get; set; }
        
        
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        
        [Display(Name = "NrTel")]
        public string NrTel { get; set; }
        
       
        [Display(Name = "Adres")]
        public Adres Adres { get; set; }
    }
}