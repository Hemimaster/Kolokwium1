using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium1.Entities;

[Table("Track")]
public class Track
{
    [Key]
    public int TrackId { get; set; }

    [MaxLength(100)]
    public string Name { get; set; } = null!;
    
    [Column(TypeName = "decimal(5,2)")]
    public decimal LengthInKm { get; set; }
    
    public ICollection<TrackRace> TrackRaces { get; set; }
        = new List<TrackRace>();
}