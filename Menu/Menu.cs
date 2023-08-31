using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Menu
    {
        
        public static List<Cibo> CibiSelezionati = new List<Cibo>();
        public static double tot = 0;

        public static void stampaMenu()
        {
            Console.WriteLine("================MENU================");
            Console.WriteLine("1. Coca Cola 150ml ($2.50)");
            Console.WriteLine("2. Insalata di pollo ($5.20)");
            Console.WriteLine("3. Pizza Margherita ($10.00)");
            Console.WriteLine("4. Pizza 4 Formaggi ($12.50)");
            Console.WriteLine("5. Pz patatine fritte ($3.50");
            Console.WriteLine("6. Insalata di riso ($8.00)");
            Console.WriteLine("7. Frutta di stagione ($5.00)");
            Console.WriteLine("8. Pizza fritta ($5.00)");
            Console.WriteLine("9. Piadina vegetariana ($6.00)");
            Console.WriteLine("10. Panino Hamburger ($7.90)");
            Console.WriteLine("11. Stampa conto finale e conferma");
            Console.WriteLine("================MENU================");

            try {
                int option = Int32.Parse(Console.ReadLine());
                if(option >11 || option<0) {
                    Console.WriteLine("Opzione non disponibile");
                    stampaMenu();
                };
                switch(option) {
                    case 1:
                        Cibo cibo1 = new Cibo("Coca Cola 150ml", 2.50);
                        CibiSelezionati.Add(cibo1);
                        Console.WriteLine("Aggiunta Coca Cola 150ml all'ordine");
                        stampaMenu();
                        break;
                    case 2:
                        Cibo cibo2 = new Cibo("Insalata di pollo", 5.20);
                        CibiSelezionati.Add(cibo2);
                        Console.WriteLine("Aggiunta Insalata di pollo all'ordine");
                        stampaMenu();
                        break;
                    case 3:
                        Cibo cibo3 = new Cibo("Pizza Margherita", 10.00);
                        CibiSelezionati.Add(cibo3);
                        Console.WriteLine("Aggiunta Pizza Margherita all'ordine");
                        stampaMenu();
                        break;
                    case 4:
                        Cibo cibo4 = new Cibo("Pizza 4 Formaggi", 12.50);
                        CibiSelezionati.Add(cibo4);
                        Console.WriteLine("Aggiunta Pizza 4 Formaggi all'ordine");
                        stampaMenu();
                        break;
                    case 5:
                        Cibo cibo5 = new Cibo("Pz patatitne fritte", 3.50);
                        CibiSelezionati.Add(cibo5);
                        Console.WriteLine("Aggiunta Pz di patatine fritte all'ordine");
                        stampaMenu();
                        break;
                    case 6:
                        Cibo cibo6 = new Cibo("Insalata di riso", 8.00);
                        CibiSelezionati.Add(cibo6);
                        Console.WriteLine("Aggiunta Insalata di riso all'ordine");
                        stampaMenu();
                        break;
                    case 7:
                        Cibo cibo7 = new Cibo("Frutta di stagione", 5.00);
                        CibiSelezionati.Add(cibo7);
                        Console.WriteLine("Aggiunta Frutta di stagione all'ordine");
                        stampaMenu();
                        break;
                    case 8:
                        Cibo cibo8 = new Cibo("Pizza fritta", 5.00);
                        CibiSelezionati.Add(cibo8);
                        Console.WriteLine("Aggiunta Pizza fritta all'ordine");
                        stampaMenu();
                        break;
                    case 9:
                        Cibo cibo9 = new Cibo("Piadina vegetariana", 6.00);
                        CibiSelezionati.Add(cibo9);
                        Console.WriteLine("Aggiunta Piadina vegetariana all'ordine");
                        stampaMenu();
                        break;
                    case 10:
                        Cibo cibo10 = new Cibo("Panino Hamburger", 7.90);
                        CibiSelezionati.Add(cibo10);
                        Console.WriteLine("Aggiunto Panino Hamburger all'ordine");
                        stampaMenu();
                        break;
                    case 11:
                        stampaCarrello();
                        break;
                }
            }
            catch {
                Console.WriteLine("Hai selezionato un opzione non valida");
                stampaMenu();
            }
        }

        private static void stampaCarrello()
        {
            foreach (Cibo cibo in CibiSelezionati) {
                Console.WriteLine(cibo.Nome + " " + "$" + cibo.Prezzo);
                tot += cibo.Prezzo;
            }
            Console.WriteLine("Totale = $"+tot);
            Console.ReadLine();
        }

    }
}
