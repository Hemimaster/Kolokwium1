namespace Kolokwium1.DTOs;

public class RaceResponseDto
{
    public string Name { get; set; } = null!;
    public string Location { get; set; } = null!;
    public DateOnly Date { get; set; }
}