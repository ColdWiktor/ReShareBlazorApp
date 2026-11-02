using System.ComponentModel.DataAnnotations;

namespace ReShareBlazorApp.models
{
    public class RegisterModels
    {
        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana")]
        [MinLength(8, ErrorMessage = "Nazwa użytkownika musi mieć co najmniej 8 znaków")]
        [MaxLength(24, ErrorMessage = "Nazwa użytkownika nie może przekraczać 24 znaków")]
        public string Username { get; set; } = " ";
        [Required(ErrorMessage = "Email jest wymagany")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy adres email")]
        public string Email { get; set; } = " ";
        [Required(ErrorMessage = "Hasło jest wymagane")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków")]
        public string Password { get; set; } = " ";
        [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane")]
        [Compare(nameof(Password), ErrorMessage = "Hasła nie są zgodne")]

        public string ConfirmPassword { get; set; } = " ";
        [Range(typeof(bool), "true", "true", ErrorMessage = "Musisz zaakceptować regulamin")]
        public bool AcceptTerms { get; set; } = false;
    }
}
