using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    // klasa typu partial poniewaz rozdzielilem ja na glowna funkcjonalnosc i po kolei metody
    // dla kazdej klasy wiec tu znajduja sie metody dla logiki konsoli dla klasy Computer

    // Tu jest funkcjonalnosc dla klasy Computer
    partial class ConsoleLogic
    { 

        // wyswietlenie panelu pokazujacego wszystkie dostepne komputery, iteruje sie foreachem przez liste list typu Computer
        // i wyswietlam z kazdej tylko element z indexem 0, poniewaz znajduja sie tam identyczne obiekty (poza id)
        public int DesktopChoicePanel()
        {
            int index = 1;
            foreach (List<Computer> x in computers)
            {
                Console.WriteLine($"Computer number: {index}");
                Console.WriteLine();
                x[0].ShowMainParams();
                Console.WriteLine("--------------------------------------");
                index++;
            }

            Console.Write("Choose one to have a closer look on it or type 9 to go back to main page (Input number): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            return choice;
        }

        // Panel na ktorym wyswietlaja sie wszystkie parametry wybranego przez uzytkownika wczesniej komputera
        // zezwala na dodanie do koszyka (brak tej funkcjonalnosci, powod nizej), powrot do listy komputerow oraz
        // powrot do menu glownego sklepu
        public int DesktopPanel(int choiceParam)
        {
            int index = 1;
            foreach (List<Computer> x in computers)
            {
                if (index == choiceParam)
                {
                    x[0].ShowAllParams();
                    Console.WriteLine("--------------------------------------");
                    break;
                }
                else
                {
                    index++;
                }
            }

            Console.WriteLine("1. Add to cart");
            Console.WriteLine("2. Go back to desktops");
            Console.WriteLine("9. Go back to main page");
            Console.Write("(Input number): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            return choice;
        }

        // Ponizsza metoda wywoluje powyzej zdefiniowane funkcje, funkcja MyProgram to funkcja glowna, wyswietlajaca menu glowne,
        // jest zdefiniowana w innym pliku
        public void Desktop()
        {
            int choice = DesktopChoicePanel();

            if (choice == 9)
            {
                MyProgram();
            }
            else
            {
                switch (DesktopPanel(choice))
                {
                    case 1:
                        // Tutaj znajdowac powinna sie funkcjonalnosc dodawania do koszyka, ale nie ma jej w zalozeniu
                        // projektu wiec jej nie dodalem, ale rozpatrujemy te klasy w kontekscie sklepu internetowego
                        // wiec dalem informacje ze powinno to sie tu znajdowac

                        break;
                    case 2:
                        Desktop();

                        break;
                    case 9:
                        MyProgram();

                        break;
                    default:
                        DesktopPanel(choice);

                        break;
                }
            }
        }
    }
}
