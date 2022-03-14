using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using System.Diagnostics;

namespace SoruceGenerator
{
    [Generator]
    public class BaseExceptionGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            Debugger.Launch();

            foreach (var file in context.AdditionalFiles)
            {
                var jsSourceText = file.GetText();
                var jsonText = jsSourceText?.ToString();
                var baseException = JsonConvert.DeserializeObject<BaseException>(jsonText);
            }
            context.AddSource("BaseException", @"
// This is generated file
using System;

namespace Test {
    
    public partial class Hello {
    
        public static void Display() {
            
            Console.WriteLine(""Hello world"");
            
        }
    
    }

}
");
        }

        public void Initialize(GeneratorInitializationContext context)
        {
        }
    }
}
