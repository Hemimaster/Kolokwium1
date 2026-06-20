using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium1.Entities;

[Table("Racer")]
public class Racer
{
    [Key]
    public int Racerid { get; set; }

    [MaxLength(50)]
    public string FirstName { get; set; } = null!;

    [MaxLength(100)]
    public string LastName { get; set; } = null!;

    public ICollection<RaceParticipation> RaceParticipations { get; set; }
        = new List<RaceParticipation>();
}