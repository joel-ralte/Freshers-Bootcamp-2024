import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

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
@Configuration
class CarConfig {

    @Bean
    public IStartUpMotor startUpMotor() {
        return new StartUpMotor();
    }

    @Bean
    public IFuelPump fuelPump() {
        return new FuelPump();
    }

    @Bean
    public IEngine engine(IStartUpMotor startUpMotor, IFuelPump fuelPump) {
        return new Engine(startUpMotor, fuelPump);
    }

    @Bean
    public ITransmission transmission() {
        return new Transmission();
    }

    @Bean
    public Car car(IEngine engine, ITransmission transmission) {
        return new Car(engine, transmission);
    }
}
class Main {
    public static void main(String[] args) {
        var context = new org.springframework.context.annotation.AnnotationConfigApplicationContext(CarConfig.class);
        Car carObj = context.getBean(Car.class);
        context.close();
    }
}
