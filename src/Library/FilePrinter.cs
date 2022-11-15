using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {

        //Cambio Recipe por IRecipeContent para aplicar DIP

        public void PrintRecipe(IRecipeContent recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}