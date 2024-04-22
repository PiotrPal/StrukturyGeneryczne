using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne {
    internal class Program {
        static void Main(string[] args) {
            //#TABLICE
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

            //#LISTA
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

            //#KOLEJKA
            //Queue<Pracownik> kolejka = new Queue<Pracownik>();

            //kolejka.Enqueue(new Pracownik { Name = "Geralt ", Surname = "Z Rivii" });
            //kolejka.Enqueue(new Pracownik { Name = "Ravix ", Surname = "Z Czteroroga" });
            //kolejka.Enqueue(new Pracownik { Name = "Jaskier ", Surname = "Pankratz" });
            //kolejka.Enqueue(new Pracownik { Name = "Cahir ", Surname = "aep Ceallach" });
            //kolejka.Enqueue(new Pracownik { Name = "Emiel ", Surname = "Regis" });

            //while (kolejka.Count > 0) {
            //    var pracownik = kolejka.Dequeue();
            //    Console.WriteLine(pracownik.Name + "" + pracownik.Surname);
            //}

            //#STOS...(przeniesione do oddzielnych metod)
            //Kolejka();
            //Stos();

            ////#HashSet int
            //HashSet<int> set = new HashSet<int>();
            //set.Add(1);
            //set.Add(10);
            //set.Add(2);
            //set.Add(3);
            //set.Add(4);
            //set.Add(5);
            //set.Add(6);
            //set.Add(7);
            //set.Add(8);
            //set.Add(9);
            //set.Add(10);
            //set.Add(10);

            //Console.WriteLine("\n-----HashSet-----");
            //foreach (int i in set) {
            //    Console.WriteLine(i);
            //}

            //HashSet();

            //#LinkedList
            //LinkedList();
            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(1);
            //list.AddFirst(3);
            //list.AddFirst(7);

            //var item1 = list.First;// to jest węzeł a nie pierwszy element
            //var itemLast = list.Last;

            //list.AddAfter(item1, 9);
            //list.AddBefore(item1, 22);
            //list.AddBefore(item1, 69);

            //Console.WriteLine("--x---LList---x--");

            ////zamiast foreach
            //var wezel = list.First;
            //while (wezel != null) {
            //    Console.WriteLine(wezel.Value);
            //    wezel = wezel.Next;
            //}

            //#SŁownik
            // Dictionary<string, Pracownik> slownik = new Dictionary<string, Pracownik>(); // mozna krocej z var
            //Dictionary();

            //#SortedDictionary
            //SortedDictionary();

            //#SortedList

            //var listaPosortowana = new SortedList<int, string>();

            //listaPosortowana.Add(2, "dwa");
            //listaPosortowana.Add(1, "jeden");
            //listaPosortowana.Add(3, "trzy");
            //listaPosortowana.Add(0, "zero");

            //foreach (var item in listaPosortowana) {
            //    Console.WriteLine(item.Value);
            //}

            //#SortedSet
            SortedSet();
        }

        private static void SortedSet() {
            var set = new SortedSet<int>();

            set.Add(8);
            set.Add(3);
            set.Add(6);
            set.Add(7);
            set.Add(1);
            set.Add(1);
            set.Add(2);
            set.Add(4);
            set.Add(5);

            Console.WriteLine("\tint");
            foreach (var item in set) {
                Console.WriteLine(item);
            }

            var set2 = new SortedSet<string>();
            set2.Add("ma");
            set2.Add("ala");
            set2.Add("zeby");
            set2.Add("cegla");
            set2.Add("kota");
            set2.Add("cegla");

            Console.WriteLine("\tstring");
            foreach (var item in set2) {
                Console.WriteLine(item);
            }
        }

        private static void SortedDictionary() {
            var pracownicy = new SortedDictionary<string, List<Pracownik>>(); //tu by bylo lepsze zastosowanie SortedList 

            pracownicy.Add("Sprzedaz", new List<Pracownik>() {
                new Pracownik {Name = "Vimme ", Surname="Vivaldi" },
                new Pracownik {Name = "Giacomo ", Surname="Cianfanelli" },
                new Pracownik {Name = "Geralt ", Surname="z Rivii" }
            });

            pracownicy.Add("IT", new List<Pracownik>() {
                new Pracownik {Name = "Emiel ", Surname="Regis" },
                new Pracownik {Name = "Cahir ", Surname="aep Ceallach" }
            });

            pracownicy.Add("Ksiegowosc", new List<Pracownik>() {
                new Pracownik {Name = "Yennefer ", Surname="z Vengerbergu" },
                new Pracownik {Name = "Triss ", Surname="Merigold" },
                new Pracownik {Name = "Vringilla", Surname = "Vigo"},
                new Pracownik {Name = "Tissaia", Surname ="de Vries"}
            });

            Console.WriteLine("\tRaport pracownikow: ");

            foreach (var item in pracownicy) {
                Console.WriteLine("Ilosc pracownikow w dziale {0}, wynosi: {1}", item.Key, item.Value.Count);
            }
        }

        private static void Dictionary() {
            var slownik = new Dictionary<string, List<Pracownik>>();
            slownik.Add("Ksiegowosc", new List<Pracownik>() {
                new Pracownik { Surname = "Nowak" },
                new Pracownik { Surname = "Merigold" },
                new Pracownik { Surname = "Metz" } });

            #region bezListy
            //var kowal = slownik["Nowak"];
            //foreach (var item in slownik) {
            //    Console.WriteLine("{0}:{1}",item.Key,item.Value.Surname);
            //}
            #endregion

            slownik["Ksiegowosc"].Add(new Pracownik { Surname = "Nowak" });

            slownik.Add("IT", new List<Pracownik>() {
                new Pracownik { Surname = "Emreis" },
                new Pracownik {Surname = "Vigo" } });

            foreach (var item in slownik) {
                Console.WriteLine("\tDział: " + item.Key);
                foreach (var pracownik in item.Value) {
                    Console.WriteLine(pracownik.Surname);
                }
            }

            Console.WriteLine("\tPracownicy z ksiegowosci");
            foreach (var item in slownik["Ksiegowosc"]) {
                Console.WriteLine(item.Surname);
            }
        }

        private static void LinkedList() {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(3);
            list.AddFirst(7);
            list.AddLast(0);
            list.AddLast(2);

            Console.WriteLine("-----LList-----");
            foreach (var item in list) {
                Console.WriteLine(item);
            }
        }

        private static void HashSet() {
            HashSet<Pracownik> set = new HashSet<Pracownik>();
            var pracownikTest = new Pracownik { Name = "Calante" };

            set.Add(pracownikTest);
            set.Add(pracownikTest);
            set.Add(new Pracownik { Name = "Ciri" });
            set.Add(new Pracownik { Name = "Ciri" });

            foreach (Pracownik p in set) {
                Console.WriteLine(p.Name);
            }
        }

        private static void Stos() {
            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { Name = "Cahir ", Surname = "aep Ceallach" });
            stos.Push(new Pracownik { Name = "Triss ", Surname = "Merigold" });
            stos.Push(new Pracownik { Name = "Leo ", Surname = "Bonhart" });

            Console.WriteLine("\n--------Stos-------");
            while (stos.Count > 0) {
                var pracownik = stos.Pop();
                Console.WriteLine(pracownik.Name + "" + pracownik.Surname);
            }
        }

        private static void Kolejka() {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Name = "Geralt ", Surname = "Z Rivii" });
            kolejka.Enqueue(new Pracownik { Name = "Ravix ", Surname = "Z Czteroroga" });
            kolejka.Enqueue(new Pracownik { Name = "Jaskier ", Surname = "Pankratz" });

            Console.WriteLine("\n--------Kolejka-------");
            while (kolejka.Count > 0) {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Name + "" + pracownik.Surname);
            }
        }
    }
}
