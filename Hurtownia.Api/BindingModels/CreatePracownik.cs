using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Hurtownia.Data.DAO;

namespace Hurtownia.Api.BindingModels
{
    public class CreatePracownik
    {
                [Required]
                [Display(Name = "Imie")]
                public string Imie { get; set; }
                
                [Required]
                [Display(Name = "Nazwisko")]
                public string Nazwisko { get; set; }
                
                [Required]
                [Display(Name = "Stanowisko")]
                public string Stanowisko { get; set; }
                
                [Required]
                [Display(Name = "PensjaBrutto")]
                public float PensjaBrutto { get; set; }
                
                [Required]
                [Display(Name = "Adres")]
                public Adres Adres { get; set; }
    }
}