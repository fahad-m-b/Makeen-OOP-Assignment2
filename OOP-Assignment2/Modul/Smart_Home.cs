using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment2.Modul
{
    public enum DeviceType
    {
        Light,
        Fan,
        AC,
        Heater
    }
    public interface ISmartDevice
    {
        void TurnOn();
        void TurnOff();
        void ShowStatus();
    }
    class Light : ISmartDevice
    {
        bool isOn;
        public void ShowStatus()
        {
            Console.WriteLine($"Light status: {(isOn ? "ON" : "OFF")}");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Light is Off");
        }

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Light is on");
        }
    }
    public class Fan : ISmartDevice
    {
        private bool isOn;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Fan is now ON.");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Fan is now OFF.");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Fan status: {(isOn ? "ON" : "OFF")}");
        }
    }

    public class AC : ISmartDevice
    {
        private bool isOn;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("AC is now ON.");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("AC is now OFF.");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"AC status: {(isOn ? "ON" : "OFF")}");
        }
    }

    public class Heater : ISmartDevice
    {
        private bool isOn;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Heater is now ON.");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Heater is now OFF.");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Heater status: {(isOn ? "ON" : "OFF")}");
        }
    }
    public class SmartHome
    {
        private ISmartDevice[] devices = new ISmartDevice[4];

        public SmartHome()
        {
            devices[(int)DeviceType.Light] = new Light();
            devices[(int)DeviceType.Fan] = new Fan();
            devices[(int)DeviceType.AC] = new AC();
            devices[(int)DeviceType.Heater] = new Heater();
        }
        public ISmartDevice this[DeviceType type]
        {
            get { return devices[(int)type]; }
        }
    }
}
