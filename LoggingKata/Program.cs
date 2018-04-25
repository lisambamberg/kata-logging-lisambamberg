using System;
using System.Data.Common;
using System.Linq;
using System.IO;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using GeoCoordinatePortable;

namespace LoggingKata
{
    class Program
    {
        static readonly ILog logger = new TacoLogger();
        private const string CsvPath = "TacoBell-US-AL.csv";

        private static void Main(string[] args)
        {
            logger.LogInfo("Log initialized");

            var lines = File.ReadAllLines(CsvPath);

            var parser = new TacoParser();

            var locations = lines.Select(parser.Parse);

            ITrackable a = null;
            ITrackable b = null;
            double distance = 0;

            foreach (var locA in locations)
            {
                var origin = new GeoCoordinate(locA.Location.Latitude, locA.Location.Longitude);

                foreach (var locB in locations)
                {
                    var destination = new GeoCoordinate(locB.Location.Latitude, locB.Location.Longitude);

                    var newDistance = origin.GetDistanceTo(destination);

                    if (!(newDistance > distance))
                    {
                        continue;
                    }

                    a = locA;
                    b = locB;
                    distance = newDistance;
                }
            }

            Console.WriteLine($"These are the two Taco Bells furthest away from each other: \n\t{a?.Name} and \n\t{b?.Name}");
            Console.WriteLine($"They are {distance / 0.000621371} miles apart.");
            Console.ReadLine();
        }
    }
}


