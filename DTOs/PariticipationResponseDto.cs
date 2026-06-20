namespace Kolokwium1.DTOs;

public class ParticipationResponseDto
{
    public RaceResponseDto Race { get; set; } = null!;
    public TrackResponseDto Track { get; set; } = null!;
    public int Laps { get; set; }
    public int FinishTimeInSeconds { get; set; }
    public int Position { get; set; }
}
