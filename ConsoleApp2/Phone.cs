using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    // stworzenie klasy ostatecznej (sealed, nic nie moze juz z niej dziedziczyc) dziedziczacej po klasie abstrakcyjnej electronic
    sealed class Phone : Electronic
    {
        private string Model;
        private decimal BackCameraResolution;
        private decimal FrontCameraResolution;
        private decimal ScreenSize;
        private int BatteryTime;

        // Zdefiniowanie konstruktora bazujacego na konstruktorze z klasy rodzica
        public Phone(string _Brand, int _RAMmemory, int _DiskCapacity, string _Processor, string _OS, string _Motherboard, decimal _Price, string _GPU, decimal _BackCameraResolution, decimal _FrontCameraResolution, decimal _ScreenSize, int _BatteryTime, string _Model) : base(_Brand, _RAMmemory, _DiskCapacity, _Processor, _OS, _Motherboard, _Price, _GPU)
        {
            Model = _Model;
            BackCameraResolution = _BackCameraResolution;
            FrontCameraResolution = _FrontCameraResolution;  
            ScreenSize = _ScreenSize;
            BatteryTime = _BatteryTime;
        }

        // Nadpisanie metod zdefiniowanych w klasie rodzica o wyswietlanie pol tej klasy
        public override void ShowMainParams()
        {
            Console.WriteLine($"Model: {Model}");
            base.ShowMainParams();
        }

        public override void ShowAllParams()
        {
            Console.WriteLine($"Model: {Model}");
            base.ShowAllParams();
            Console.WriteLine($"Front camera resolution: {FrontCameraResolution} Mpix");
            Console.WriteLine($"Back camera resolution: {BackCameraResolution} Mpix");
            Console.WriteLine($"Screen size: {ScreenSize} inches");
            Console.WriteLine($"On battery time: {BatteryTime} hours");
        }

        // Zdefiniowanie metod abstrakcyjnych z klasy rodzica
        public override void TurnOn()
        {
            Console.WriteLine("You just turned on your phone!");
        }

        public override void TurnOff()
        {
            Console.WriteLine("You just turned off your phone!");
        }

        public void InputSimCard()
        {
            Console.WriteLine("The sim card is inputed now you can make calls!");
        }
    }
}
