using System.Numerics;
using System.Security.Cryptography.X509Certificates;

public class Vehicle {
    public string Name { get; set; }
    public int Speed { get; set; }

    public static int TotalVehicles;

    public Vehicle (string name, int speed) {
        Name = name;
        Speed = speed;

        TotalVehicles++;

    }

    public virtual void Start() {
        Console.WriteLine("Veihcle is starting!");
    }

    public virtual void Accelarte(int increment) {
        Speed += increment;
    }

    public virtual int GetSpeed() {
        return Speed;
    }
}

public class Car : Vehicle {
    public int FuelEfficiency { get; set; }
    public Car (string name, int speed) : base(name, speed) {
        

    }
            public override void Start() {
            Console.WriteLine ("The car is starting with a smooth engine sound!");
        }
}

public class Motorcycle : Vehicle {
    public Motorcycle (string name, int speed) : base(name, speed) {

    }
    public override void Start()    {
        Console.WriteLine("The motorcycle roars to life!");
    }
    public override void Accelarte(int increment)
    {
        base.Accelarte(increment * 2);
    }
}

public class Truck : Vehicle {
    public int CargoCapacity { get; set; }
    public Truck (string name, int speed) : base(name, speed) {

    }
    public override void Start()
    {
     Console.WriteLine("The truck's heavy engine rumbles as it starts!");   
    }

}


public class Program {
public static void Main() {
    Vehicle[] vehicles= {
        new Car ("Car", 10),
        new Motorcycle ("Motorcycle", 40),
        new Truck ("Truck", 15),
    };

    for (int i = 0; i < vehicles.Length; i++) {
        vehicles[i].Start();
    }
    Console.WriteLine("\n"); //padding
   foreach (Vehicle v in vehicles) {
    Console.WriteLine($"{v.Name} speed:{v.Speed} Mph");
    
   }
    Console.WriteLine("\n"); //padding
    Console.WriteLine("Total vehicles created: " + Vehicle.TotalVehicles);
    
    }
}