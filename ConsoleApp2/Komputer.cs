using System;

namespace Shop
{
    // stworzenie klasy ostatecznej (sealed, nic nie moze juz z niej dziedziczyc) dziedziczacej po klasie abstrakcyjnej electronic
    sealed class Computer : Electronic
    {
        private int PowerSupply;

        // Zdefiniowanie konstruktora bazujacego na konstruktorze z klasy rodzica
        public Computer(string _Brand, int _RAMmemory, int _DiskCapacity, string _Processor, string _OS, string _Motherboard, int _Price, string _GPU, int _PowerSupply) : base(_Brand, _RAMmemory, _DiskCapacity, _Processor, _OS, _Motherboard, _Price, _GPU)
        {
            this.PowerSupply = _PowerSupply;
        }

        // Nadpisanie metody zdefiniowanej w klasie rodzica o wyswietlanie pol tej klasy
        public override void ShowAllParams()
        {
            base.ShowAllParams();
            Console.WriteLine($"Power supply: {PowerSupply}");
        }

        // Zdefiniowanie metod abstrakcyjnych z klasy rodzica
        public override void TurnOn()
        {
            Console.WriteLine("You just turned on your computer!");
        }

        public override void TurnOff()
        {
            Console.WriteLine("You just turned off your computer!");
        }

        public void ChangeProcessor()
        {
            Console.Write("Input new processor :");
            var processor = Console.ReadLine();

            if (processor != null)
            {
                Processor = processor;
            }
        }
    }
}
