﻿using System;
using Microsoft.SqlServer.Server;
using CoordinateSharp;

namespace UTM2LATSqlServerLibrary
{
    public static class UTM2LATSqlServerLibrary
    {
        /// <summary>
        /// Converts UTM Zone 17 Region South to Latitude and Longitude using CoordinateSharp nuget library
        /// </summary>
        /// <param name="XUTM">pos UTM X</param>
        /// <param name="YUTM">pos UTM Y</param>
        /// <returns>Latitude</returns>
        [SqlProcedure]
        public static double UTM2LAT(double XUTM, double YUTM)
        {

            UniversalTransverseMercator utm = new UniversalTransverseMercator("S", 17, XUTM, YUTM);
            Coordinate c = UniversalTransverseMercator.ConvertUTMtoLatLong(utm);

            return c.Latitude.DecimalDegree;
        }

        /// <summary>
        /// Converts UTM Zone 17 Region South to Latitude and Longitude using CoordinateSharp nuget library
        /// </summary>
        /// <param name="XUTM">Posición UTM X</param>
        /// <param name="YUTM">Posición UTM Y</param>
        /// <returns>Longitude</returns>
        [SqlProcedure]
        public static double UTM2LONG(double XUTM, double YUTM)
        {

            UniversalTransverseMercator utm = new UniversalTransverseMercator("S", 17, XUTM, YUTM);
            Coordinate c = UniversalTransverseMercator.ConvertUTMtoLatLong(utm);

            return c.Longitude.DecimalDegree;
        }

        /// <summary>
        /// Converts WGS84/UTM to Latitude and Longitude using CoordinateSharp nuget library
        /// </summary>
        /// <param name="XUTM">pos UTM X</param>
        /// <param name="YUTM">pos UTM Y</param>
        /// <param name="LatBand">Latitude band grid zone designation letter (see http://www.dmap.co.uk/utmworld.htm) </param>
        /// <param name="LongBand">Longitude band grid zone designation number (see http://www.dmap.co.uk/utmworld.htm) </param>
        /// <returns>Latitude</returns>
        [SqlProcedure]
        public static double UTM2LATITUDE(double XUTM, double YUTM, string LatBand, int LongBand)
        {

            UniversalTransverseMercator utm = new UniversalTransverseMercator(LatBand, LongBand, XUTM, YUTM);
            Coordinate c = UniversalTransverseMercator.ConvertUTMtoLatLong(utm);

            return c.Latitude.DecimalDegree;

        }

        /// <summary>
        /// Converts UTM Zone 30 Polar Region South to Latitude and Longitude using CoordinateSharp nuget library
        /// </summary>
        /// <param name="XUTM">pos UTM X</param>
        /// <param name="YUTM">pos UTM Y</param>
        /// <param name="LatBand">Latitude band grid zone designation letter (see http://www.dmap.co.uk/utmworld.htm) </param>
        /// <param name="LongBand">Longitude band grid zone designation number (see http://www.dmap.co.uk/utmworld.htm) </param>
        /// <returns>Longitude</returns>
        [SqlProcedure]
        public static double UTM2LONGITUDE(double XUTM, double YUTM, string LatBand, int LongBand)
        {

            UniversalTransverseMercator utm = new UniversalTransverseMercator(LatBand, LongBand, XUTM, YUTM);
            Coordinate c = UniversalTransverseMercator.ConvertUTMtoLatLong(utm);

            return c.Longitude.DecimalDegree;
        }


    }
}