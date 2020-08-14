using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            DataFlow<string> dataFlowString = new DataFlow<string>();

            dataFlowString.AddBlock(new UpperCaseBlock());
            dataFlowString.AddBlock(new ReverseBlock());
            dataFlowString.AddBlock(new ReplaceAWithSixBlock());

            Console.WriteLine(dataFlowString.RunFlow("afek"));
        }
    }
}
