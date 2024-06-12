﻿using HealthMate.Domain.Enums;

namespace HealthMate.API.DTO.ShortModels
{
    public class ShortMoodDTO(
        Guid UserId,
        MoodStatus MoodStatus,
        int StressLevel,
        ICollection<ShortNoteDTO>? Notes
    );
}
