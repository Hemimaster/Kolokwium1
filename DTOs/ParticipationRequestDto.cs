using System.ComponentModel.DataAnnotations;

namespace Kolokwium1.DTOs;

public class ParticipationRequestDto
{
    [Range(1, int.MaxValue)]
    public int RacerId { get; set; }

    [Range(1, int.MaxValue)]
    public int Position { get; set; }

    [Range(1, int.MaxValue)]
    public int FinishTimeInSeconds { get; set; }
}