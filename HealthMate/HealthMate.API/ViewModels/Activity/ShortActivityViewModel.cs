﻿using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.Activity
{
    public class ShortActivityViewModel
    {
        public Guid UserId { get; set; }
        public Guid ActivityTypeId { get; set; }
        public TimeSpan Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public DateOnly Date { get; set; }
        public List<ShortNoteViewModel>? Notes { get; set; } = new();
    }
}
