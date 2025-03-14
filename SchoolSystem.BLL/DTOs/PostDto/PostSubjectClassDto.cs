﻿using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.BLL.DTOs.PostDto
{
    public class PostSubjectClassDto
    {

        public int ClassId { get; set; }

        public int SubjectId { get; set; }

        public int SubjectTeacher { get; set; }

        public string SubjectClassName { get; set; } = null!;
    }

}
