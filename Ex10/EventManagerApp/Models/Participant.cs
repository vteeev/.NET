using System.ComponentModel.DataAnnotations;

namespace EventManagerApp.Models;

public class Participant
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Imię i nazwisko jest wymagane")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email jest wymagany")]
    [EmailAddress(ErrorMessage = "Nieprawidłowy format adresu email")]
    public string Email { get; set; }

    public int EventId { get; set; }
}