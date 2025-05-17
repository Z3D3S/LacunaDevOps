using System.Collections.Generic;

namespace LacunaDevOps.Api
{
    public class RecipeData
    {
        public string Name { get; set; }
        
        public string Preparation { get; set; }

        public List<IngredientInRecipeData> IngredientInRecipeDatas { get; set; }
    }
}
