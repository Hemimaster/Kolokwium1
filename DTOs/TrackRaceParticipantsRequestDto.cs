using System.ComponentModel.DataAnnotations;

namespace Kolokwium1.DTOs;

public class TrackRaceParticipantsRequestDto
{   
    [Required]
    [MaxLength(50)]
    public string RaceName { get; set; } = null!;
    
    [Required]
    [MaxLength(100)]
    public string TrackName { get; set; } = null!;
    
    [Required]
    [MinLength(1)]
    public List<ParticipationRequestDto> Participations { get; set; } = [];

}