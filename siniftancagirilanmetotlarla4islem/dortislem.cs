using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace siniftancagirilanmetotlarla4islem
{
    internal class dortislem
    {
        public int Dortislem(int s1, int s2)
        {
            int toplamsonuc = s1 + s2;
            int cikarmasonuc = s1 - s2;
            int carpmasonuc = s1 * s2;
            int bolmesonuc = s1 / s2;

            int sonuc = toplamsonuc + cikarmasonuc + carpmasonuc + bolmesonuc;

            Console.WriteLine("Toplama Sonucu: " + toplamsonuc +  "\n" + "Çıkarma Sonucu: " + cikarmasonuc + "\n" + "Çarpma Sonucu: " + carpmasonuc + "\n" + "Bölme Sonucu: " + bolmesonuc);
            return sonuc;
            
        }
    }
}
