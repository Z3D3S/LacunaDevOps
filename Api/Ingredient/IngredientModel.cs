using System;

namespace LacunaDevOps.Api
{
    public class IngredientModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public UnitOfMeasure StandardUnitOfMeasure { get; set; }
    }
}
