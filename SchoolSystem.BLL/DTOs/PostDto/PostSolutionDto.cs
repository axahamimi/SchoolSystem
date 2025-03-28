﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.BLL.DTOs.PostDto
{
    public class PostSolutionDto
    {
        public int HomeWorkId { get; set; }

        public int StudentId { get; set; }

        public string? SolutionImage { get; set; }

        public string? SolutionFile { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? SolutionDate { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? SolutionDegree { get; set; }

        public string? Solutionnote { get; set; }
    }

}
