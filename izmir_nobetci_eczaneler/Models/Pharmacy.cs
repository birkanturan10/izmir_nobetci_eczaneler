using System.ComponentModel;

namespace izmir_nobetci_eczaneler.Models
{
    public class Pharmacy
    {
        public DateTime Tarih { get; set; }

        [DisplayName("Eczane Adı")]
        public string? Adi { get; set; }

        public string? Telefon { get; set; }

        [DisplayName("Bölge")]
        public string? Bolge { get; set; }

        public string? Adres { get; set; }
    }
}
