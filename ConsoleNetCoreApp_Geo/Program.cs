using System;
using GeoCoordinatePortable;

namespace ConsoleNetCoreApp_Geo
{
    class Program
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/api/system.device.location.geocoordinate.isunknown?view=netframework-4.8
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GeoCoordinate geo = new(39.195, -94.68194);
            Console.WriteLine();
        }

        /// <summary>
        /// https://stackoverflow.com/questions/60700865/find-distance-between-2-coordinates-in-net-core
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        public double CalculateDistance(Location point1, Location point2)
        {
            var d1 = point1.Latitude * (Math.PI / 180.0);
            var num1 = point1.Longitude * (Math.PI / 180.0);
            var d2 = point2.Latitude * (Math.PI / 180.0);
            var num2 = point2.Longitude * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);
            return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        }

    }

    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}


public static class GeoExtensions
{
    /// <summary>
    /// Validate sender is a valid latitude
    /// </summary>
    /// <param name="value">double value to validate</param>
    /// <returns>true if valid, false if not valid</returns>
    public static bool IsLatitude(this double value) => value is <= 90.0 and >= -90.0;
    /// <summary>
    /// Validate sender is a valid longitude
    /// </summary>
    /// <param name="value">double value to validate</param>
    /// <returns>true if valid, false if not valid</returns>
    public static bool IsLongitude(this double value) => value is <= 180.0 and >= -180.0;
}


