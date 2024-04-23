using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace _3_KlasyInterfejsyGeneryczne {
    public static class KolejkaExtensions {
        public static IEnumerable<Tout> ElementJakoInt<T,Tout>(this IKolejka<T> queue ) {
            var konwerter = TypeDescriptor.GetConverter(typeof(T));

            foreach (var item in queue) {
                var wynik = konwerter.ConvertTo(item, typeof(Tout));
                yield return (Tout)wynik;
            }
        }

        public static void Drujuj<T>(this IKolejka<T>queue) {
            foreach (var item in queue) {
                Console.WriteLine(item);
            }
        }
    }
}
