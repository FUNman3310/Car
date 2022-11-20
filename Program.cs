Car car = new Car()
{
    Brand = "Mercedes-Benz",
    Model = "Maybach",
    Fuel = 173,
    FuelFor1Km = 12,
    Millage = 0
};

int Km;

Console.WriteLine("Нow many km do you want to drive?");
bool Check = Int32.TryParse(Console.ReadLine(), out Km);

while (!Check)
{
    Console.WriteLine("Нow many km do you want to drive?");
    Check = Int32.TryParse(Console.ReadLine(), out Km);
} 

car.Drive(Km);

class Car
{
    public string Brand;
    public string Model;
    public int Fuel;
    public int FuelFor1Km;
    public int Millage;
    public  void Drive(int Km)
    {
        for (int i = 0; i < Km; i++,Millage++, Fuel-=FuelFor1Km)
        {
            if (Fuel<FuelFor1Km)
            {
                Console.WriteLine($"\nNot Enough Fuel! Current Fuel Level: {Fuel}");
                break;
            }
        }

        Console.Write("\nMillage: ");
        Console.Write(Millage);
        Console.Write("\nFuel: ");
        Console.Write(Fuel);

        if (Fuel > FuelFor1Km)
        {
            ReDrive();
        }
        
    }
    public void ReDrive()
    {
        Console.WriteLine("\n\nIf you want continue press 'h' \nIf you want to stop, press any key");
        string Choise = Console.ReadLine();
        int Km;

        switch (Choise)
        {
            case "h":
                Console.WriteLine("\nНow many km do you want to drive?");
                bool Check = Int32.TryParse(Console.ReadLine(), out Km);

                while (!Check)
                {
                    Console.WriteLine("\nНow many km do you want to drive?");
                    Check = Int32.TryParse(Console.ReadLine(), out Km);
                } 

                Drive(Km);

                break; 
            default:
                Console.WriteLine("\nYou have finished your trip!");
                break;
        }
    }

}