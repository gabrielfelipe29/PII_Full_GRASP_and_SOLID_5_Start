using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        //Cambio Recipe por IRecipeContent para aplicar DIP

        public void PrintRecipe(IRecipeContent recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}