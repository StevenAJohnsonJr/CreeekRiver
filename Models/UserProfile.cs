﻿using CreeekRiver.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CreeekRiver.Models;

public class UserProfile
{
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Email { get; set; }

    public List<Reservations> Reservations { get; set; }

}