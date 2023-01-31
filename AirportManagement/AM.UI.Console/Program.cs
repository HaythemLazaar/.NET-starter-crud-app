// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

Plane Plane1 = new Plane()
{
    Capacity = 1,
    ManufactureDate = new DateTime(2021, 10, 5),
    PlaneType = PlaneType.Boing
};

//Plane1.Capacity = 1;
//Plane1.ManufactureDate = new DateTime(2021, 10, 5);
//Plane1.PlaneType = PlaneType.Boing;

//Plane Plane2 = new Plane(PlaneType.Airbus, 55, new DateTime(2010, 4, 5));

Plane Plane2 = new Plane()
{
    Capacity = 55,
    ManufactureDate = new DateTime(2010, 4, 5),
    PlaneType = PlaneType.Airbus
};

Passenger p1 = new Passenger()
{
    PassportNumber = 436346346,
    FirstName = "HA1",
    LastName = "HA1"
};

Traveller p2 = new Traveller()
{
    PassportNumber = 436346347,
    FirstName = "HA2",
    LastName = "HA2"
};

Staff p3 = new Staff()
{
    PassportNumber = 436346348,
    FirstName = "HA3",
    LastName = "HA3"
};


// Affichage

Console.WriteLine(Plane1.ToString());
Console.WriteLine(Plane2.ToString());
Console.WriteLine(p1.ToString());
Console.WriteLine(p2.ToString());
Console.WriteLine(p3.ToString());
Console.WriteLine(p1.PassengerType());
Console.WriteLine(p2.PassengerType());
Console.WriteLine(p3.PassengerType());






