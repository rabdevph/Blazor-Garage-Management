using System.ComponentModel.DataAnnotations;

namespace GarageManagement.SampleData.Models;

public class Vehicle
{
    public int Id { get; set; }

    [Required]
    public string Make { get; set; } = string.Empty;

    [Required]
    public string Model { get; set; } = string.Empty;

    public int Year { get; set; }

    public string? Vin { get; set; }

    [Required]
    public string LicensePlate { get; set; } = string.Empty;

    public string? Color { get; set; }

    public string? Notes { get; set; }
}
