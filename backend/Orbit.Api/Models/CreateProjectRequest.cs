using System.ComponentModel.DataAnnotations;

namespace Orbit.Api.Models;

public class CreateProjectRequest
{
    [Required]
    [StringLength(100, MinimumLength = 1)]
    public string Name { get; set; } = string.Empty;

    [StringLength(2000)]
    public string? Description { get; set; }
}
