using Microsoft.Extensions.DependencyInjection;

interface IEngine { }
interface ITransmission { }
interface IStartUpMotor { }
interface IFuelPump { }

class Car
{
    public IEngine Engine { get; }
    public ITransmission Transmission { get; }

    public Car(IEngine engine, ITransmission transmission)
    {
        Engine = engine;
        Transmission = transmission;
    }
}

class Engine : IEngine
{
    public IStartUpMotor StartUpMotor { get; }
    public IFuelPump FuelPump { get; }

    public Engine(IStartUpMotor startUpMotor, IFuelPump fuelPump)
    {
        StartUpMotor = startUpMotor;
        FuelPump = fuelPump;
    }
}

class Transmission : ITransmission { }

class StartUpMotor : IStartUpMotor { }

class FuelPump : IFuelPump { }

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IStartUpMotor, StartUpMotor>()
            .AddSingleton<IFuelPump, FuelPump>()
            .AddSingleton<IEngine, Engine>()
            .AddSingleton<ITransmission, Transmission>()
            .AddSingleton<Car>(serviceProvider =>
            {
                var engine = serviceProvider.GetRequiredService<IEngine>();
                var transmission = serviceProvider.GetRequiredService<ITransmission>();
                return new Car(engine, transmission);
            })
            .BuildServiceProvider();

        var carObj = serviceProvider.GetRequiredService<Car>();
        serviceProvider.Dispose();
    }
}
