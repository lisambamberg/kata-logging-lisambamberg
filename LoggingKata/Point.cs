namespace LoggingKata
{
    public struct Point
    {
        public static readonly double MaxLat = 180;
        public static readonly double MaxLon = 90;
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}