﻿using System;
using System.Collections.Generic;

namespace SchoolSystem.DAL.Entites;

public partial class TeacherTable
{
    public int TeacherTableId { get; set; }

    public int UserId { get; set; }

    public string? TheDay { get; set; }

    public string? PeriodOne { get; set; }

    public string? PeriodTow { get; set; }

    public string? PeriodThree { get; set; }

    public string? PeriodFour { get; set; }

    public string? PeriodFive { get; set; }

    public string? PeriodSix { get; set; }

    public string? PeriodSeven { get; set; }

    public string? PeriodEight { get; set; }

    public virtual User User { get; set; } = null!;
}
