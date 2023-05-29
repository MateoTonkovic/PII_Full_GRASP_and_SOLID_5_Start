using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public IGetTextToPrint entityToPrint;
        public ConsolePrinter(IGetTextToPrint _entityToPrint)
        {
            this.entityToPrint = _entityToPrint;
        }


        public void PrintRecipe()
        {
            Console.WriteLine(this.entityToPrint.GetTextToPrint());
        }
    }
}