namespace Kolokwium1.DTOs;

public class RacerResponseDto
{
    public int RacerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public List<ParticipationResponseDto> Participations { get; set; } = [];
}