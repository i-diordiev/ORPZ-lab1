using System;
using System.Collections.Generic;
using System.Linq;

namespace ORPZ_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Helicopter> helicopters = new List<Helicopter>()
            {
                new Helicopter() { Type = "Eurocopter EC120", MaximumHeight = 5180, MaximumFlightRange = 727, LoadCapacity = 755, AirlineId = 1},
                new Helicopter() { Type = "Eurocopter EC120", MaximumHeight = 5180, MaximumFlightRange = 727, LoadCapacity = 755, AirlineId = 1},
                new Helicopter() { Type = "Eurocopter EC130", MaximumHeight = 7010, MaximumFlightRange = 606, LoadCapacity = 1160, AirlineId = 1},
                new Helicopter() { Type = "Sikorsky S-70", MaximumHeight = 5835, MaximumFlightRange = 584, LoadCapacity = 1200, AirlineId = 1},
                new Helicopter() { Type = "Sikorsky S-76", MaximumHeight = 3870, MaximumFlightRange = 761, LoadCapacity = 1616, AirlineId = 1},
                new Helicopter() { Type = "Eurocopter EC120", MaximumHeight = 5180, MaximumFlightRange = 727, LoadCapacity = 755, AirlineId = 2},
                new Helicopter() { Type = "Eurocopter EC130", MaximumHeight = 7010, MaximumFlightRange = 606, LoadCapacity = 1160, AirlineId = 2},
                new Helicopter() { Type = "Sikorsky S-70", MaximumHeight = 5835, MaximumFlightRange = 584, LoadCapacity = 1200, AirlineId = 2},
                new Helicopter() { Type = "Sikorsky S-70", MaximumHeight = 5835, MaximumFlightRange = 584, LoadCapacity = 1200, AirlineId = 2},
                new Helicopter() { Type = "Eurocopter EC130", MaximumHeight = 7010, MaximumFlightRange = 606, LoadCapacity = 1160, AirlineId = 3},
                new Helicopter() { Type = "Sikorsky S-70", MaximumHeight = 5835, MaximumFlightRange = 584, LoadCapacity = 1200, AirlineId = 3},
                new Helicopter() { Type = "Sikorsky S-70", MaximumHeight = 5835, MaximumFlightRange = 584, LoadCapacity = 1200, AirlineId = 3},
                new Helicopter() { Type = "Eurocopter EC120", MaximumHeight = 5180, MaximumFlightRange = 727, LoadCapacity = 755, AirlineId = 4},
                new Helicopter() { Type = "Eurocopter EC120", MaximumHeight = 5180, MaximumFlightRange = 727, LoadCapacity = 755, AirlineId = 4},
                new Helicopter() { Type = "Eurocopter EC130", MaximumHeight = 7010, MaximumFlightRange = 606, LoadCapacity = 1160, AirlineId = 4}
            };

            List<Plane> planes = new List<Plane>()
            {
                new Plane() {Type = "Boeing 777", Wingspan = 60.9f, LoadCapacity = 35000, MaximumFlightRange = 11135, TakeoffRunLength = 2500, AirlineId = 1},
                new Plane() {Type = "Boeing 777", Wingspan = 60.9f, LoadCapacity = 35000, MaximumFlightRange = 11135, TakeoffRunLength = 2500, AirlineId = 1},
                new Plane() {Type = "Airbus A330", Wingspan = 60.3f, LoadCapacity = 45000, MaximumFlightRange = 13400, TakeoffRunLength = 2300, AirlineId = 1},
                new Plane() {Type = "Airbus A380", Wingspan = 79.75f, LoadCapacity = 50000, MaximumFlightRange = 15200, TakeoffRunLength = 2050, AirlineId = 1},
                new Plane() {Type = "Airbus A380", Wingspan = 79.75f, LoadCapacity = 50000, MaximumFlightRange = 15200, TakeoffRunLength = 2050, AirlineId = 1},
                new Plane() {Type = "Airbus A350", Wingspan = 64.75f, LoadCapacity = 30000, MaximumFlightRange = 15200, TakeoffRunLength = 2600, AirlineId = 2},
                new Plane() {Type = "Airbus A350", Wingspan = 64.75f, LoadCapacity = 30000, MaximumFlightRange = 15200, TakeoffRunLength = 2600, AirlineId = 2},
                new Plane() {Type = "Boeing 777", Wingspan = 60.9f, LoadCapacity = 40000, MaximumFlightRange = 11135, TakeoffRunLength = 3410, AirlineId = 2},
                new Plane() {Type = "Boeing 777", Wingspan = 60.9f, LoadCapacity = 40000, MaximumFlightRange = 11135, TakeoffRunLength = 3410, AirlineId = 2},
                new Plane() {Type = "Airbus A380", Wingspan = 79.75f, LoadCapacity = 50000, MaximumFlightRange = 15200, TakeoffRunLength = 2050, AirlineId = 2},
                new Plane() {Type = "Airbus A380", Wingspan = 79.75f, LoadCapacity = 50000, MaximumFlightRange = 15200, TakeoffRunLength = 2050, AirlineId = 2},
                new Plane() {Type = "Boeing 777", Wingspan = 60.9f, LoadCapacity = 35000, MaximumFlightRange = 9695, TakeoffRunLength = 2500, AirlineId = 3},
                new Plane() {Type = "Boeing 777", Wingspan = 60.9f, LoadCapacity = 35000, MaximumFlightRange = 9695, TakeoffRunLength = 2500, AirlineId = 3},
                new Plane() {Type = "Boeing 777", Wingspan = 60.9f, LoadCapacity = 35000, MaximumFlightRange = 9695, TakeoffRunLength = 2500, AirlineId = 3},
                new Plane() {Type = "Airbus A380", Wingspan = 79.75f, LoadCapacity = 50000, MaximumFlightRange = 15200, TakeoffRunLength = 2050, AirlineId = 3},
                new Plane() {Type = "Airbus A380", Wingspan = 79.75f, LoadCapacity = 50000, MaximumFlightRange = 15200, TakeoffRunLength = 2050, AirlineId = 3},
                new Plane() {Type = "Airbus A380", Wingspan = 79.75f, LoadCapacity = 50000, MaximumFlightRange = 15200, TakeoffRunLength = 2050, AirlineId = 3},
                new Plane() {Type = "Airbus A380", Wingspan = 79.75f, LoadCapacity = 50000, MaximumFlightRange = 15200, TakeoffRunLength = 2050, AirlineId = 3},
                new Plane() {Type = "Boeing 777", Wingspan = 60.9f, LoadCapacity = 35000, MaximumFlightRange = 9695, TakeoffRunLength = 2500, AirlineId = 4},
                new Plane() {Type = "Boeing 777", Wingspan = 60.9f, LoadCapacity = 35000, MaximumFlightRange = 9695, TakeoffRunLength = 2500, AirlineId = 4},
                new Plane() {Type = "Boeing 787", Wingspan = 60.17f, LoadCapacity = 42000, MaximumFlightRange = 13620, TakeoffRunLength = 3100, AirlineId = 4},
                new Plane() {Type = "Airbus A350", Wingspan = 64.75f, LoadCapacity = 30000, MaximumFlightRange = 15200, TakeoffRunLength = 2600, AirlineId = 4},
                new Plane() {Type = "Airbus A350", Wingspan = 64.75f, LoadCapacity = 30000, MaximumFlightRange = 15200, TakeoffRunLength = 2600, AirlineId = 4}
            };

            List<Airline> airlines = new List<Airline>()
            {
                new Airline() { Id = 1, Name = "Qatar Airways", OfficeLocation = "Doha", DateOfCreation = new DateTime(1994, 01, 20)},
                new Airline() { Id = 2, Name = "Singapore Airlines", OfficeLocation = "Singapore", DateOfCreation = new DateTime(1947, 05, 01)},
                new Airline() { Id = 3, Name = "Emirates", OfficeLocation = "Dubai", DateOfCreation = new DateTime(1985, 03, 25)},
                new Airline() { Id = 4, Name = "Japan Airlines", OfficeLocation = "Tokyo", DateOfCreation = new DateTime(1951, 08, 01)},
            };

            var query1 = from a in airlines
                select a;
            Console.WriteLine("Query 1");
            Console.WriteLine("Show information about airlines");
            Console.WriteLine("Result: ");
            foreach (var result in query1)
            {
                Console.WriteLine(result.Name + ", " + result.OfficeLocation + ", " + result.DateOfCreation);
            }

            var query2 = from p in planes 
                where p.Wingspan > 62
                orderby p.Wingspan, p.Type
                select p;
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("Query 2");
            Console.WriteLine("Select planes with wingspan > 62, sort by wingspan and if equal, sort by type");
            Console.WriteLine("Result: ");
            foreach (var result in query2)
            {
                Console.WriteLine(result.Type + ", wingspan - " + result.Wingspan);
            }
            
        }
    }
}