using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    // klasa typu partial poniewaz rozdzielilem ja na glowna funkcjonalnosc i po kolei metody
    // dla kazdej klasy wiec tu znajduja sie metody dla logiki konsoli dla klasy Computer

    // Tu jest funkcjonalnosc głowna
    partial class ConsoleLogic
    {
        private List<List<Computer>> computers = new List<List<Computer>>();
        private List<List<Laptop>> laptops= new List<List<Laptop>>();
        private List<List<Phone>> phones = new List<List<Phone>>();

        public ConsoleLogic(List<List<Computer>> _computers, List<List<Laptop>> _laptops, List<List<Phone>> _phones)
        {
            this.computers = _computers;
            this.laptops = _laptops;
            this.phones = _phones;
        }

        public void ChoicePanel(int choice)
        {
            if (choice == 1)
            {
                // Wywolanie menu sklepu

                MyProgram();
            }
            else
            {
                Computer c1 = new Computer("X-KOM", 16, 1000, "i3-12100F", "Windows 10", "GIGABYTE B550", 4000, "AMD Radeon RX 6600", 500);

                Console.WriteLine("Dla klasy Computer: ");
                Console.WriteLine("");
                c1.TurnOn();
                Console.WriteLine("------------------------");
                c1.ShowMainParams();
                Console.WriteLine("------------------------");
                c1.ChangeProcessor();
                Console.WriteLine("------------------------");
                c1.ShowMainParams();
                Console.WriteLine("------------------------");
                c1.TurnOff();
                Console.WriteLine("------------------------");

                Laptop l1 = new Laptop("ASUS", 16, 1000, "Intel Core i7", "Windows 10", "ASUS Motherboard", 6000, "Nvidia GeForce RTX 3080", "Mechanical", 17, 4, true);

                Console.WriteLine("Dla klasy Laptop: ");
                Console.WriteLine("");
                l1.ShowAllParams();
                Console.WriteLine("------------------------");
                l1.ChangeBattery();
                Console.WriteLine("------------------------");
                l1.ShowAllParams();
                Console.WriteLine("------------------------");

                Phone p1 = new Phone("Apple", 4, 64, "Apple A14 Bionic", "iOS 14", "Apple Motherboard", 3000, "Apple GPU", 12, 12, 6.1m, 17, "iPhone 12");

                Console.WriteLine("Dla klasy Phone: ");
                Console.WriteLine("");
                p1.InputSimCard();

                Console.WriteLine("");
                Console.WriteLine("Niektore metody nie zostaly uzyte tutaj ale zostaly uzyte w menu sklepu");


            }
        } 

        public int MainPanel()
        {
            Console.WriteLine("-----Welcome in our store, what are you looking for today?-----");
            Console.WriteLine("1. Desktops");
            Console.WriteLine("2. Laptops");
            Console.WriteLine("3. Mobile Phones");
            Console.WriteLine("9. Exit");
            Console.Write("(Input number): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            return choice;
        }

        // metoda MyProgram wywoluje metody MainPanel() zdefiniowana wyzej, Desktop() zdefiniowana w pliku 
        // ComputerConsole, Laptop() zdefiniowana w pliku LaptopConsole oraz Phone() zdefiniowana w pliku
        // PhoneConsole
        public void MyProgram()
        {
            switch (MainPanel())
            {
                case 1:
                    Desktop();


                    break;

                case 2:
                    Laptop();

                    break;

                case 3:
                    Phone();

                    break;
                case 9:
                    Console.WriteLine("Bye!!!");

                    break;

                default:
                    MyProgram();

                    break;
            }
        }
    }
}
