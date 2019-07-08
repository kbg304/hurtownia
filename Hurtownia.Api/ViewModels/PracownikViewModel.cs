

namespace Hurtownia.Api.ViewModels
{
    public class PracownikViewModel
    {
        public int PracownikId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Stanowisko { get; set; }
        public float PensjaBrutto { get; set; }
    }
}