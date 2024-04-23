using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;

namespace _4_MetodyDelegatyGeneryczne {

    public delegate void Drukarka<T>(T dane);
    public static class KolejkaExtensions {
        public static IEnumerable<Tout> ElementJako<T, Tout>(this IKolejka<T> queue) {
            var konwerter = TypeDescriptor.GetConverter(typeof(T));

            foreach (var item in queue) {
                var wynik = konwerter.ConvertTo(item, typeof(Tout));
                yield return (Tout)wynik;
            }
        }

        public static IEnumerable<Tout> Mapuj<T, Tout>(this IKolejka<T> queue, Converter<T, Tout> converter) {
            //foreach (var item in queue) {
            //    var wynik = converter(item);
            //    yield return wynik;
            //}

            //skrocony zapis z LinQ
            return queue.Select(i => converter(i));

        }

        public static void Drukuj<T>(this IKolejka<T> queue, Action<T> wydruk) {
            foreach (var item in queue) {
                wydruk(item);
            }
        }
    }
}
