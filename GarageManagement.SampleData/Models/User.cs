using System.ComponentModel.DataAnnotations;
using GarageManagement.SampleData.Enums;

namespace GarageManagement.SampleData.Models;

public class User
{
    public int Id { get; set; }

    [Required]
    public string Username { get; set; } = string.Empty;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string FullName =>
        string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName)
            ? Username
            : $"{FirstName} {LastName}".Trim();

    public UserRole Role { get; set; }

    [Required]
    public string Password { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;
}
