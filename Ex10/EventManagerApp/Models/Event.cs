using System.ComponentModel.DataAnnotations;
using EventManagerApp.Validations.Attributes;

namespace EventManagerApp.Models;

public class Event
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Tytuł jest wymagany")]
    [MinLength(3, ErrorMessage = "Tytuł musi mieć minimum 3 znaki")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Data jest wymagana")]
    [FutureDate(ErrorMessage = "Data musi być w przyszłości")]
    public DateTime Date { get; set; }

    public string? Description { get; set; } // "string?" dopuszcza również wartość null
}