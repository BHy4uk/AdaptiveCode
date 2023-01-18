using System.Reflection;
using Refactoring.Processors;

class Program
{
    static void Main(string[] args)
    {
        var inputs = new List<string>()
        {
            "empty-file.txt"
        };

        var originalConsoleOut = Console.Out;
        
        foreach (var input in inputs)
        {
            var tradeStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(typeof(Program), input);

            using (var streamWriter = new StreamWriter(File.OpenWrite($"expectation - {input}")))
            {
                Console.SetOut(streamWriter);
            }

            var tradeProcessor = new TradeProcessor();
            tradeProcessor.ProcessTrades(tradeStream);

            Console.SetOut(originalConsoleOut);
            Console.ReadKey();
        }
    }
}