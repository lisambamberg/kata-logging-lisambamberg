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
                // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
                //var cells = line.Split(',');

                // If your array.Length is less than 3, something went wrong
             //   if (cells.Length < 3)
               // {
                 //   return null;
                    // Log that and return null
              //  }

                // grab the long from your array at index 0
                // grab the lat from your array at index 1
                // grab the name from your array at index 2
                

                // Your going to need to parse your string as a `double`
                // which is similar to parse a string as an `int`
               /*

                try
                {
                    var results = double.Parse("");
                   // var longitude = 0.0;
                    var maxLong = 180.0;
                    //var latitude = 0.0;
                    var maxLat = 90.0;
                    var name = "";

                    var longitude = new cells[0];
                    var latitude = new cells[1];
                    var name = new cells[2];

                    if (longitude < maxLong || latitude < maxLat)
                    {
                        return null;
                    }

                }

                catch (Exception)
                {
                    return null;
                }
                // You'll need to create a TacoBell class
                // that conforms to ITrackable

                // Then, you'll need an instance of the TacoBell class
                // With the name and point set correctly

                // Then, return the instance of your TacoBell class
                // Since it conforms to ITrackable
            }*/
            //DO not fail if one record parsing fails, return null
           return null; //TODO Implement
                }
        }
    }
}