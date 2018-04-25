using System;
using System.Linq;
using System.IO;

namespace LoggingKata
{
    class Program
    {
        //Why do you think we use ILog?
        static readonly ILog logger = new TacoLogger();
        private const string CsvPath = "TacoBell-US-AL.csv";

        private static void Main(string[] args)
        {
            logger.LogInfo("Log initialized");

            var lines = File.ReadAllLines(CsvPath);

            logger.LogInfo($"Lines: {lines[0]}");

            var parser = new TacoParser();

            var locations = lines.Select(parser.Parse);

           

            // TODO:  Find the two TacoBells in Alabama that are the furthurest from one another.
            // HINT:  You'll need two nested foreachloops

            //foreach
            //origin nd destination 

            // compare and find greatest possible points 
        }
    }
}