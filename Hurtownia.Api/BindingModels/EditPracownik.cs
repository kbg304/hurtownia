using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Hurtownia.Data.DAO;

namespace Hurtownia.Api.BindingModels
{
    public class EditPracownik
    {
        
        [Display(Name = "Imie")] 
        public string Imie { get; set; }
        
        [Display(Name = "Nazwisko")] 
        public string Nazwisko { get; set; }
        
        [Display(Name = "Stanowisko")] 
        public string Stanowisko { get; set; }
        
        [Display(Name = "PensjaBrutto")] 
        public float PensjaBrutto { get; set; }
        
        [Display(Name = "Adres")] 
        public Adres Adres { get; set; }
    }
}