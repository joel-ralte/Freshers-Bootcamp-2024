import java.util.*;

interface IEngine {
    
}
interface ITransmission {
    
}
interface IStartUpMotor {
    
}
interface IFuelPump {
    
}
class Car {
    IEngine engine;
    ITransmission transmission;
    
    Car(IEngine engine, ITransmission transmission) {
        this.engine = engine;
        this.transmission = transmission;
    }
}
class Engine implements IEngine{
    IStartUpMotor startUpMotor;
    IFuelPump fuelPump;
    
    Engine(IStartUpMotor startUpMotor, IFuelPump fuelPump) {
        this.startUpMotor = startUpMotor;
        this.fuelPump = fuelPump;
    }
}
class Transmission implements ITransmission{
    
}
class StartUpMotor implements IStartUpMotor{
    
}
class FuelPump implements IFuelPump{
    
}
class HelloWorld {
    public static void main(String[] args) {
        IStartUpMotor startUpMotor = new StartUpMotor();
        IFuelPump fuelPump = new FuelPump();
        
        IEngine engine = new Engine(startUpMotor, fuelPump);
        ITransmission transmission = new Transmission();
        
        Car carObj = new Car(engine, transmission);
        
        System.out.println("Test");
    }
}
