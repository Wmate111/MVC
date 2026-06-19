using System.ComponentModel.DataAnnotations;

namespace katalogfilmowMVC.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany.")]
        [StringLength(100, ErrorMessage = "Tytuł może mieć maksymalnie 100 znaków.")]
        [Display(Name = "Tytuł")]
        public string Tytul { get; set; } = string.Empty;

        [Required(ErrorMessage = "Reżyser jest wymagany.")]
        [StringLength(100, ErrorMessage = "Reżyser może mieć maksymalnie 100 znaków.")]
        [Display(Name = "Reżyser")]
        public string Rezyser { get; set; } = string.Empty;

        [Required(ErrorMessage = "Gatunek jest wymagany.")]
        [StringLength(50, ErrorMessage = "Gatunek może mieć maksymalnie 50 znaków.")]
        [Display(Name = "Gatunek")]
        public string Gatunek { get; set; } = string.Empty;

        [Required(ErrorMessage = "Rok produkcji jest wymagany.")]
        [Range(1888, 2100, ErrorMessage = "Podaj poprawny rok produkcji.")]
        [Display(Name = "Rok produkcji")]
        public int RokProdukcji { get; set; }

        [Required(ErrorMessage = "Ocena jest wymagana.")]
        [Range(1, 10, ErrorMessage = "Ocena musi być w zakresie od 1 do 10.")]
        [Display(Name = "Ocena")]
        public int Ocena { get; set; }

        [StringLength(500, ErrorMessage = "Opis może mieć maksymalnie 500 znaków.")]
        [Display(Name = "Opis")]
        public string? Opis { get; set; }
    }
}