﻿using HealthMate.API.Abstractions;
using System.Text.Json.Serialization;

namespace HealthMate.API.ViewModels.Medication
{
    public class ShortMedicationViewModel : BaseViewModelWithNotesAndDate
    {
        public Guid UserId { get; set; }
        public string MedicationName { get; set; } = string.Empty;
        public string Dosage { get; set; } = string.Empty;
        public string Frequency { get; set; } = string.Empty;
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}
