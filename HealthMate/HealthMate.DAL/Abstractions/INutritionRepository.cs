﻿using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public interface INutritionRepository : IModelWithNotesAndDateRepository<NutritionEntity>
    {
    }
}
