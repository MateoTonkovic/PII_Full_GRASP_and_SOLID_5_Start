using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public IGetTextToPrint entityToPrint;

        public FilePrinter(IGetTextToPrint _entityToPrint)
        {
            this.entityToPrint = _entityToPrint;
        }

        public void PrintRecipe()
        {
            File.WriteAllText("Recipe.txt", this.entityToPrint.GetTextToPrint());
        }
    }
}