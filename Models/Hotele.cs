using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HotelShowcaseWebApp.Data.Enum;

namespace HotelShowcaseWebApp.Models {
    public class Hotele {
        [Key]
        public int id_hotelu { get; set; }
        public string? nazwa_hotelu { get; set; }
        public string? adres { get; set; }
        public float ocena { get; set; }
        public string? typ_hotelu { get; set; }
        public string? udogodnienia { get; set; }
        public int ilosc_pokoi { get; set; }
        public float cena_za_noc {get; set; }
    }
}