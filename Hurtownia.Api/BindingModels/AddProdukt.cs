using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Hurtownia.Data.DAO;
using Microsoft.CodeAnalysis;

namespace Hurtownia.Api.BindingModels
{
    public class AddProdukt
    {
        [Required]
        [Display(Name = "Producent")]
        public string Producent { get; set; }
        
        [Required]
        [Display(Name = "Model")]
        public string Model { get; set; }
        
        [Required]
        [Display(Name = "Nazwa")]
        public string Nazwa { get; set; }
        
        [Required]
        [Display(Name = "CenaNetto")]
        public float CenaNetto { get; set; }
        
        [Required]
        [Display(Name = "Kategoria")]
        public Kategoria Kategoria { get; set; }
        
        
    }
}