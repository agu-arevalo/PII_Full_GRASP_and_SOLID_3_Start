using System.IO;
namespace Full_GRASP_And_SOLID.Library
{
    public class PrinterPrinter : IPrinter {
        public void Print(Recipe recipe){
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }   
    }
}