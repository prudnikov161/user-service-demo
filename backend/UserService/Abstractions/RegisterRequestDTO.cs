using System.ComponentModel.DataAnnotations;

namespace UserService.Abstractions;

public record RegisterRequestDTO(
    string Email,
    string Password,
    [Required(ErrorMessage = "FullName cannot be empty.")]
    string FullName
);