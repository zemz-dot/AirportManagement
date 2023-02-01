// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

Plane p = new Plane();
    p.Planeid = 1;
    p.PlaneType = PlaneType.Boing;
    p.ManufactureDate = new DateTime(2022, 12, 30);
    p.Capacity = 200;

    Console.WriteLine(p);

Plane p1 = new Plane(100, new DateTime(2015, 01, 16), PlaneType.Airbus);

    Console.WriteLine(p1);

Passenger passenger = new Passenger();
passenger.PassengerType();

Staff staff = new Staff();
staff.PassengerType();

Traveller traveller = new Traveller();
traveller.PassengerType();