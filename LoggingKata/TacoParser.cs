using System;
using System.Linq.Expressions;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the TacoBells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();

        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            {
                //Done  // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
                //Done // If your array.Length is less than 3, something went wrong

                // grab the long from your array at index 0
                // grab the lat from your array at index 1
                // grab the name from your array at index 2

                //Done // Your going to need to parse your string as a `double`
                // which is similar to parse a string as an `int`
                var cells = line.Split(',');
                if (cells.Length < 3)
                {
                    logger.LogWarning("This is not valid");
                    return null;
                }

                if (string.IsNullOrEmpty(line))
                {
                    logger.LogWarning("Contains empty string and cannot be parsed.");
                    return null;
                }

                try
                {
                    // ?var results = double.Parse();
                    var longitude = double.Parse(cells[0]);
                   // ?var maxLong = double.Parse();
                    var latitude = double.Parse(cells[1]);
                   // ?var maxLat = double.Parse();
                   
                   // ?var location

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return null;
                }
                // You'll need to create a TacoBell class
                // that conforms to ITrackable

                // Then, you'll need an instance of the TacoBell class
                // With the name and point set correctly

                // Then, return the instance of your TacoBell class
                // Since it conforms to ITrackable

                //DO not fail if one record parsing fails, return null
                return null; //TODO Implement
            }
        }
    }
}