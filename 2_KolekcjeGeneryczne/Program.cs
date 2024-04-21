using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne {
    internal class Program {
        static void Main(string[] args) {
            //TABLICE
            //Pracownik[] pracownicy = new Pracownik[] {
            //    new Pracownik{Name = "Jack", Surname = "Sparrow"},
            //    new Pracownik{Name = "David", Surname = "Jones"},
            //    new Pracownik{Name = "William", Surname = "Turner"}
            //};

            //foreach (var value in pracownicy) {
            //    Console.WriteLine(value.Name + " " + value.Surname);
            //}

            //Array.Resize(ref pracownicy, 10);

            //pracownicy[9] = new Pracownik { Name = "Capitan", Surname = "Barbossa" };

            //LISTA
            //List<Pracownik> pracownicy = new List<Pracownik> {
            //    new Pracownik{Name = "Jack", Surname = "Sparrow"},
            //    new Pracownik{Name = "David", Surname = "Jones"},
            //    new Pracownik{Name = "William", Surname = "Turner"}
            //};

            //pracownicy.Add(new Pracownik { Name = "Bill", Surname = "Bucior" });

            //foreach (var value in pracownicy) {
            //    Console.WriteLine(value.Name + " " + value.Surname);
            //}

            //Console.WriteLine("----------------------------");

            //var liczby = new List<int>();
            //var pojemnosc = -1;

            //pojemnosc = liczby.Capacity;
            //Console.WriteLine("pojemnosc1: " + pojemnosc);

            //while (true) {

            //    if (liczby.Capacity != pojemnosc) {
            //        pojemnosc = liczby.Capacity;
            //        Console.WriteLine("pojemnosc: " + pojemnosc);
            //    }
            //    liczby.Add(1);
            //}

            //KOLEJKA
            Queue<Pracownik> kolejka = new Queue<Pracownik>();

            kolejka.Enqueue(new Pracownik { Name = "Geralt ", Surname = "Z Rivii" });
            kolejka.Enqueue(new Pracownik { Name = "Ravix ", Surname = "Z Czteroroga" });
            kolejka.Enqueue(new Pracownik { Name = "Jaskier ", Surname = "Pankratz" });
            kolejka.Enqueue(new Pracownik { Name = "Cahir ", Surname = "aep Ceallach" });
            kolejka.Enqueue(new Pracownik { Name = "Emiel ", Surname = "Regis" });

            while (kolejka.Count > 0) {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Name + "" + pracownik.Surname);

            }
        }
    }
}
