## A .NET class library for Converting WGS84/UTM coordinates to Latitude and Longitude using CoordinateSharp nuget library This library contains utility methods that can be called from Microsoft SQL Server as SQL functions within transact sql code (t-sql)

To access UTM Grid Zones, http://www.dmap.co.uk/utmworld.htm

Ex. 
```
SELECT FACILITYID, dbo.UTM2LATITUDE(shape.STX, shape.STY, 'S', 17) AS Latitude,
dbo.UTM2LONGITUDE(shape.STX, shape.STY, 'S', 17) AS Longitude
FROM dbo.MyFeatureSet
```
