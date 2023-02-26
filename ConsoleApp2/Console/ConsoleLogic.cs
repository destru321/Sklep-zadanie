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
