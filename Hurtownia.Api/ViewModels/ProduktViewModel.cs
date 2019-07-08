using Hurtownia.Data.DAO;


namespace Hurtownia.Api.ViewModels
{
    public class ProduktViewModel
    {
        public int ProduktId { get; set; }
        
        public string Producent { get; set; }
        
        public string Model { get; set; }
        
        public string Nazwa { get; set; }
        
        public float CenaNetto { get; set; }
        
        

    }
}