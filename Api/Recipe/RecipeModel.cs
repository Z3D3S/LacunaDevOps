using System;
using System.Collections.Generic;

namespace LacunaDevOps.Api.Recipe
{
    public class RecipeModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Preparation { get; set; }

        public List<IngredientInRecipeModel> ingredientInRecipes { get; set; }
    }
}
