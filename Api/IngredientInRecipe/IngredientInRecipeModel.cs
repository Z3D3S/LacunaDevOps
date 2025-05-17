using System;

namespace LacunaDevOps.Api
{
    public class IngredientInRecipeModel
    {
        public int Quantity { get; set; }

        public IngredientModel Ingredient { get; set; }
    }
}
