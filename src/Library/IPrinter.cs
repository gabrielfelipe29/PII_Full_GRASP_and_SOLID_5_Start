
namespace Full_GRASP_And_SOLID
{
    public interface IPrinter
    {
        //Cambio Recipe por IRecipeContent para aplicar DIP
         void PrintRecipe(IRecipeContent recipe);
    }
}