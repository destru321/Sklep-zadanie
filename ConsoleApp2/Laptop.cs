using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    // stworzenie klasy ostatecznej (sealed, nic nie moze juz z niej dziedziczyc) dziedziczacej po klasie abstrakcyjnej electronic
    sealed class Laptop : Electronic
    {
        private string KeyboardType;
        private int ScreenSize;
        private int BatteryTime;
        private bool WebCamera;

        // Zdefiniowanie konstruktora bazujacego na konstruktorze z klasy rodzica
        public Laptop(string _Brand, int _RAMmemory, int _DiskCapacity, string _Processor, string _OS, string _Motherboard, int _Price, string _GPU, string _KeyboardType, int _ScreenSize, int _BatteryTime, bool _WebCamera) : base(_Brand, _RAMmemory, _DiskCapacity, _Processor, _OS, _Motherboard, _Price, _GPU)
        {
            KeyboardType = _KeyboardType;
            ScreenSize = _ScreenSize;
            BatteryTime = _BatteryTime;
            WebCamera = _WebCamera;
        }

        // Nadpisanie metody zdefiniowanej w klasie rodzica o wyswietlanie pol tej klasy
        public override void ShowAllParams()
        {
            base.ShowAllParams();
            Console.WriteLine($"Keyboard type: {KeyboardType}");
            Console.WriteLine($"Screen size: {ScreenSize} inches");
            Console.WriteLine($"On battery time: {BatteryTime} hours");
            Console.WriteLine($"Got camera: {WebCamera} ");
        }

        // Zdefiniowanie metod abstrakcyjnych z klasy rodzica
        public override void TurnOn()
        {
            Console.WriteLine("You just turned on your laptop!");
        }

        public override void TurnOff()
        {
            Console.WriteLine("You just turned off your laptop!");
        }

        public void ChangeBattery()
        {
            Console.WriteLine("You changed your battery, on battery time went up by 5 hours!");
            BatteryTime += 5;
        }
    }
}