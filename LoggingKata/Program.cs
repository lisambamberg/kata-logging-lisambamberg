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

            Console.WriteLine("These are the two Taco Bells furthest away from each other: \n\t{a?.Name} and \n\t{b?.Name}");
            Console.WriteLine("They are {distance} /3.28 feet apart.");
            Console.ReadLine();
        }
        // compare and find greatest possible points 
        // Now, here's the new code

        // Done //Create two `ITrackable` variables with initial values of `null`. These will be used to store your two taco bells that are the furthest from each other.
        // Done //Create a `double` variable to store the distance

        // Done // Include the Geolocation toolbox, so you can compare locations: `using GeoCoordinatePortable;`
        // Done //Do a loop for your locations to grab each location as the origin (perhaps: `locA`)
        // Done // Create a new corA Coordinate with your locA's lat and long

        // Done //Now, do another loop on the locations with the scope of your first loop, so you can grab the "destination" location (perhaps: `locB`)
        // Done //Create a new Coordinate with your locB's lat and long
        // Done //Now, compare the two using `origin.GetDistanceTo(distance)`, which returns a double
        // Done //If the distance is greater than the currently saved distance, update the distance and the two `ITrackable` variables you set above

        // Once you've looped through everything, you've found the two Taco Bells furthest away from each other.

        // TODO:  Find the two TacoBells in Alabama that are the furthurest from one another.
        // HINT:  You'll need two nested foreachloops

        //foreach
        //origin nd destination 
    }
}


