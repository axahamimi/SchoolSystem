﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.BLL.DTOs
{
    public class ClassTimeTableDto
    {
        public int ClassTimeTableId { get; set; }

        public int ClassId { get; set; }

        public string? TheDay { get; set; }

        public string? PeriodOne { get; set; }

        public string? PeriodTow { get; set; }

        public string? PeriodThree { get; set; }

        public string? PeriodFour { get; set; }

        public string? PeriodFive { get; set; }

        public string? PeriodSix { get; set; }

        public string? PeriodSeven { get; set; }

        public string? PeriodEight { get; set; }
    }
}
