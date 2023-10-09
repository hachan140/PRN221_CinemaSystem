﻿using System;
using System.Collections.Generic;

namespace CinemaSystemLibrary.DataAccess;

public partial class Film
{
    public int FilmId { get; set; }

    public int? GenreId { get; set; }

    public string Title { get; set; } = null!;

    public int? Year { get; set; }

    public string? CountryCode { get; set; }

    public virtual Country? CountryCodeNavigation { get; set; }

    public virtual Genre? Genre { get; set; }

    public virtual ICollection<Show> Shows { get; set; } = new List<Show>();
}
