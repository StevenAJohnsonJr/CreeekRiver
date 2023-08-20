using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CreeekRiver.Models;

public class Campsite
{
    public int Id { get; set; }
    [Required]
    public string Nickname { get; set; }
    public string ImageUrl { get; set; }
    public int CampsiteTypeId { get; set; }
    public CampsiteType CampsiteType { get; set; }
    public List<Reservations> Reservations { get; set; }
}
