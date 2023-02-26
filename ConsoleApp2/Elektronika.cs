using System;
using System.Collections.Generic;


namespace Shop
{
    // W klasie program znajduje sie po prostu metoda main, w ktorej tworze instancje klas oraz wywoluje dzialanie programu

    // W pliku ConsoleLogic znajduje sie tak jak nazwa wskazuje logika konsoli, czyli wszystkie operacje ktore sa wykonywane
    // w konsoli podczas dzialania programu, rozdzielilem to do innej klasy, poniewaz gdy znajdowalo sie to w tym pliku  kod
    // nie byl przejrzysty, teraz wyglada to duzo lepiej
    class Program
    {

        public static void Main(string[] args)
        {
            // Inicjuje listy przechowujace listy obiektow typu Computer, Laptop, Phone

            List<List<Computer>> computers = new List<List<Computer>>();
            List<List<Laptop>> laptops = new List<List<Laptop>>();
            List<List<Phone>> phones = new List<List<Phone>>();

            // Do list stworzonych wyzej dodaje 5 pustych list, poniewaz kazda kategoria ma po piec roznych instancji klas
            // a jako ze rozpatruje to jako sklep internetowy to kazda z nich ma osobna liste w ktorej znajduje sie 5
            // obiektow z jednakowymi polami ale innym ID

            for (int i = 0; i < 5; i++)
            {
                computers.Add(new List<Computer> { });
                laptops.Add(new List<Laptop> { });
                phones.Add(new List<Phone> { });
            }

            for (int i = 0; i < 5; i++)
            {
                computers[0].Add(new Computer("X-KOM", 16, 1000, "i3-12100F", "Windows 10", "GIGABYTE B550", 4000, "AMD Radeon RX 6600", 500));
                computers[1].Add(new Computer("X-KOM", 16, 1000, "i5-12400F", "Windows 10", "ASRock B450", 5250, "NVIDIA GeForce RTX 3060", 700));
                computers[2].Add(new Computer("X-KOM", 16, 1000, "i7-12700F", "Windows 11", "GIGABYTE B550", 6700, "NVIDIA GeForce RTX 3060", 750));
                computers[3].Add(new Computer("X-KOM", 16, 1000, "i7-13700F", "Windows 11", "GIGABYTE B550", 7800, "NVIDIA GeForce RTX 3070", 750));
                computers[4].Add(new Computer("X-KOM", 32, 2000, "i7-13700KF", "Windows 11", "MSI MAG B550 TOMAHAWK", 11000, "NVIDIA GeForce RTX 4070 TI", 850));

                laptops[0].Add(new Laptop("Dell", 8, 256, "Intel Core i5", "Windows 10", "Dell Motherboard", 3000, "Nvidia GeForce MX350", "Membrane", 15, 6, true));
                laptops[1].Add(new Laptop("Apple", 16, 512, "Apple M1 chip", "macOS Big Sur", "Apple Motherboard", 10000, "Apple M1 GPU", "Butterfly", 13, 10, true));
                laptops[2].Add(new Laptop("ASUS", 16, 1000, "Intel Core i7", "Windows 10", "ASUS Motherboard", 6000, "Nvidia GeForce RTX 3080", "Mechanical", 17, 4, true));
                laptops[3].Add(new Laptop("HP", 4, 128, "Intel Celeron", "Windows 10", "HP Motherboard", 2000, "Integrated Intel GPU", "Membrane", 14, 5, false));
                laptops[4].Add(new Laptop("Lenovo", 8, 512, "Intel Core i5", "Windows 10", "Lenovo Motherboard", 5000, "Integrated Intel GPU", "Backlit", 14, 8, true));

                phones[0].Add(new Phone("Samsung", 6, 128, "Qualcomm Snapdragon 865", "Android 11", "Samsung Motherboard", 3000, "Adreno 650", 64, 16, 6.5m, 12, "Galaxy S21"));
                phones[1].Add(new Phone("Apple", 4, 64, "Apple A14 Bionic", "iOS 14", "Apple Motherboard", 3000, "Apple GPU", 12, 12, 6.1m, 17, "iPhone 12"));
                phones[2].Add(new Phone("OnePlus", 8, 256, "Qualcomm Snapdragon 888", "Android 11", "OnePlus Motherboard", 1000, "Adreno 660", 48, 16, 6.78m, 11, "OnePlus 9 Pro"));
                phones[3].Add(new Phone("Xiaomi", 6, 128, "Qualcomm Snapdragon 870", "MIUI 12", "Xiaomi Motherboard", 1500, "Adreno 650", 48, 20, 6.67m, 10, "Mi 11"));
                phones[4].Add(new Phone("Google", 8, 128, "Qualcomm Snapdragon 765G", "Android 11", "Google Motherboard", 2000, "Adreno 620", 12.2m, 8, 6, 12, "Pixel 5"));

            }


            // Wywolanie logiki konsoli
            ConsoleLogic program = new ConsoleLogic(computers, laptops, phones);
            program.MyProgram();
        }
    }

    // Stworzenie klasy abstrakcyjnej Electronic po ktorej dziedzicza klasy Computer, Laptop oraz Phone
    public abstract class Electronic
    {
        protected Guid ID;
        protected string Brand;
        protected int RAMmemory;
        protected int DiskCapacity;
        protected string OS;
        protected string Processor;
        protected string Motherboard;
        protected decimal Price;
        protected string GPU;

        // Ponizej zdefiniowalem konstruktor oraz dwie metody, poniewaz abstrakcyjnosc klasy, metod oraz konsturktora rozni sie od siebie znaczaco.
        // Po pierwsze nie mozemy zadeklarowac, ze konstruktor jest abstrakcyjny, natomiast mozemy go zdefiniowac w klasie abstrakcyjniej. Nie 
        // mozemy go wykorzystac bezposrednio, bo nie mozemy stworzyc instancji klasy abstrakcyjnej, ale mozemy wolac go przy uzyciu konstruktora
        // klasy dziedzicznej. Stworzenie abstrakcyjnej klasy natomiast znaczy tylko to, ze nie zezwalamy na tworzenie jej instancji. Stworzenie
        // abstrakcyjnej metody oznacza ze wymagamy jej definicji od klasy dziedzicznej.
        protected Electronic(string _Brand ,int _RAMmemory, int _DiskCapacity, string _Processor, string _OS, string _Motherboard, decimal _Price, string _GPU)
        {
            this.ID = Guid.NewGuid();
            this.Brand = _Brand;
            this.RAMmemory = _RAMmemory;
            this.DiskCapacity = _DiskCapacity;
            this.OS = _OS;
            this.Processor = _Processor;
            this.Motherboard = _Motherboard;
            this.Price = _Price;
            this.GPU = _GPU;
        }

        // Stworzenie metod virtualnych, poniewaz w zaleznosci od klasy beda sie troszke zmieniac, a slowo kluczowe virtual
        // zezwala na nadpisywanie metod
        public virtual void ShowMainParams()
        {
            Console.WriteLine($"Price: {Price} zlotych");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Processor: {Processor}");
            Console.WriteLine($"GPU: {GPU}");
            Console.WriteLine($"Disk capacity: {DiskCapacity} GB");
        }

        public virtual void ShowAllParams()
        {
            ShowMainParams();
            Console.WriteLine($"RAM: {RAMmemory} GB");
            Console.WriteLine($"Operating System: {OS}");
            Console.WriteLine($"Motherboard: {Motherboard}");
        }

        // Deklaracja metod abstrakcyjnych
        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}
