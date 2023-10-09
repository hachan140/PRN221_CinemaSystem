﻿using System;
using System.Collections.Generic;

namespace CinemaSystemLibrary.DataAccess;

public partial class Room
{
    public int RoomId { get; set; }

    public string Name { get; set; } = null!;

    public int? NumberRows { get; set; }

    public int? NumberCols { get; set; }

    public virtual ICollection<Show> Shows { get; set; } = new List<Show>();
}
