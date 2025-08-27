using System.ComponentModel.DataAnnotations;

namespace GarageManagement.SampleData.Models;

public class Mechanic
{
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    public string LastName { get; set; } = string.Empty;

    public string FullName => $"{FirstName} {LastName}".Trim();

    public List<string> Specializations { get; set; } = [];

    public bool IsActive { get; set; } = true;
}
