using System;

class RemoteControlCar
{
    private int _metersTraveled = 0;
    private int _batteryUsed = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {this._metersTraveled} meters";
    }

    public string BatteryDisplay()
    {
        if(this._batteryUsed == 0){
            return "Battery empty";
        }
        return $"Battery at {this._batteryUsed}%";
    }

    public void Drive()
    {
        if(this._batteryUsed == 0){
            return;
        }
        this._metersTraveled += 20;
        this._batteryUsed--; 
    }
}