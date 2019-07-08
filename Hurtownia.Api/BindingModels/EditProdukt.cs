using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Hurtownia.Data.DAO;

namespace Hurtownia.Api.BindingModels
{
    public class EditProdukt
    {
        
        [Display(Name = "Producent")] 
        public string Producent { get; set; }
        
        [Display(Name = "Model")] 
        public string Model { get; set; }
        
        [Display(Name = "Nazwa")] 
        public string Nazwa { get; set; }
        
        [Display(Name = "CenaNetto")] 
        public float CenaNetto { get; set; }
        
        [Display(Name = "Kategoria")] 
        public Kategoria Kategoria{ get; set; }
    }
    
}