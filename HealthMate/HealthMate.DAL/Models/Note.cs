﻿using System.ComponentModel.DataAnnotations;
using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Models
{
    public class Note : BaseEntity
    {
        [StringLength(2000)]
        public required string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
