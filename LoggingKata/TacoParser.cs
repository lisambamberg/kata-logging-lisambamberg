using System;
using System.ComponentModel.DataAnnotations;
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
                var cells = line.Split(',');
                if (cells.Length < 2)
                {
                    logger.LogWarning("This is not valid");
                    return null;
                }

                if (string.IsNullOrEmpty(line))
                {
                    logger.LogError("Contains empty string and cannot be parsed.");
                    return null;
                }

                try
                {
                    var lon = double.Parse(cells[0]);
                    if (lon > Point.MaxLon || lon < -Point.MaxLon)
                    {
                        logger.LogWarning("Not within range");
                        return null;
                    }

                    var lat = double.Parse(cells[1]);
                    if (lat > Point.MaxLat || lat < -Point.MaxLat)
                    {
                        logger.LogWarning("Not within range");
                        return null;
                    }

                    var point = new Point { Latitude = lat, Longitude = lon };
                    var name = cells.Length > 2 ? cells[2] : null;
                    return new TacoBell(name, point);
                }

                catch (Exception ex)
                {
                    logger.LogError("Failure", ex);
                    return null;
                }

                //return null; //TODO Implement
            }
        }
    }
}