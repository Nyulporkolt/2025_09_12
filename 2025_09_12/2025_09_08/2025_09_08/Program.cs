using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace _2025_09_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.81;
            
            // 1. feladat
            Console.Write("Add meg a négyzet oldalát: ");
            double oldal=double.Parse(Console.ReadLine());
            Console.WriteLine($"A négyzet kerülete: {4*oldal}, területe: {Math.Pow(oldal,2)},");
            // 2. feladat
            Console.Write("Add meg a trapéz alapját: ");
            double ta=double.Parse(Console.ReadLine());
            Console.Write("Add meg a trapéz felső alapját: ");
            double tf=double.Parse(Console.ReadLine());
            Console.Write("Add meg a trapéz magasságát: ");
            double tm=double.Parse(Console.ReadLine());
            Console.WriteLine($"A trapéz területe: {(ta + tf) * tm / 2}");
            // 3. feladat
            Console.Write("Add meg a téglalap hosszát: ");
            double hossz = double.Parse(Console.ReadLine());
            Console.Write("Add meg a téglalap szélességét: ");
            double szel = double.Parse(Console.ReadLine());
            Console.WriteLine($"A téglalap területe: {hossz*szel}, kerülete pedig: {2*(hossz+szel)}");
            // 4. fealdat
            Console.Write("Add meg a háromszög alapját: ");
            double ha = double.Parse(Console.ReadLine());
            Console.Write("Add meg a háromszög magasságát: ");
            double hm = double.Parse(Console.ReadLine());
            Console.WriteLine($"A háromszög területe: {ha*hm/2}");
            // 5. feladat
            Console.Write("Add meg a kör sugarát: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine($"A kör Kerülete: {2*r*Math.PI} területe pedig: {Math.Pow(r,2)*Math.PI}");
            // 6. feladat
            Console.Write("Kérek egy pozitív számot: ");
            double poz = double.Parse(Console.ReadLine());
            Console.WriteLine($"A pozitív szám négyzetgyöke: {Math.Sqrt(poz)}");
            // 7. feladat
            Console.Write("Add meg a háromszög oldalhosszát: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Add meg a háromszög második oldalhosszát: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Add meg a háromszög harmadik oldalhosszát: ");
            double c = double.Parse(Console.ReadLine());
            double s = (a + b + c) / 2;
            Console.WriteLine($"A háromszög területe: {Math.Sqrt(s*(s-a)*(s-b)*(s-c))}");
            // 8 feéadat: 
            Console.Write("Add meg a kocka élhosszát: ");
            double el = double.Parse(Console.ReadLine());
            Console.WriteLine($"A kocka térfogata: {Math.Pow(el,3)}, felszíne pedig: {6*Math.Pow(el,2)}");
            // 9 feladat
            Console.Write("Add meg a téglatest hosszát: ");
            double thossz = double.Parse(Console.ReadLine());
            Console.Write("Add meg a téglatest szélességét: ");
            double tszel = double.Parse(Console.ReadLine());
            Console.Write("Add meg a téglatest magasságát: ");
            double tmag = double.Parse(Console.ReadLine());
            Console.WriteLine($"A téglatest térfogata: {thossz*tszel*tmag}");
            // 10. feladat
            Console.Write("Add meg a gömb sugarát: ");
            double gombsug = double.Parse(Console.ReadLine());
            Console.WriteLine($"A gömb térfogata: {4*Math.PI/3*Math.Pow(gombsug,3)} a felszine pedig {4*Math.PI*Math.Pow(gombsug,2)}");
            // 11. feladat
            Console.Write("Add meg a henger sugarát: ");
            double henr = double.Parse(Console.ReadLine());
            Console.Write("Add meg a henger magasságát: ");
            double henm = double.Parse(Console.ReadLine());
            Console.WriteLine($"A henger térfogata: {Math.Pow(henr,2)*Math.PI*henm}, felszíne pedig: {2*henr*Math.PI*(henr+henm)}");
            // 12. feladart
            Console.Write("Add meg a kúp sugarát: ");
            double kups = double.Parse(Console.ReadLine());
            Console.Write("Add meg a kúp magasságát: ");
            double kupm = double.Parse(Console.ReadLine());
            Console.WriteLine($"A kúp térfogata: {Math.Pow(kups,2)*Math.PI*kupm/3}, és a felszíne pedig: {Math.PI*kups*(kups+Math.Sqrt(Math.Pow(kups,2)+Math.Pow(kupm,2)))}");
            // 13. feladat
            Console.Write("Add meg a gúla alapjának a területét: ");
            double gat = double.Parse(Console.ReadLine());
            Console.Write("Add meg a gúla magasságát: ");
            double gm = double.Parse(Console.ReadLine());
            Console.WriteLine($"A gúla térfogata: {gat*gm/3}");
            // 14. feladat
            Console.Write("Add meg a paralelogramma egyik oldalát: ");
            double pa = double.Parse(Console.ReadLine());
            Console.Write("Add meg a paralelogramma másik oldalát: ");
            double pb = double.Parse(Console.ReadLine());
            Console.Write("Add meg a közbezárt szöget: ");
            double py = double.Parse(Console.ReadLine());
            Console.WriteLine($"A paralelogramma területe: {pa*pb*Math.Sin(py)}");
            // 15. feladat
            Console.Write("Add meg a háromszög egyik oldalát: ");
            double ha2 = double.Parse(Console.ReadLine());
            Console.Write("Add meg a háromszög másik oldalát: ");
            double hb = double.Parse(Console.ReadLine());
            Console.Write("Add meg a közbezárt szöget: ");
            double hy = double.Parse(Console.ReadLine());
            Console.WriteLine($"A háromszög harmadik oldala={Math.Sqrt(Math.Pow(ha2,2)+Math.Pow(hb,2)-2*ha2*hb*Math.Cos(hy))} a területe pedig: {ha2*hb*Math.Sin(hy)/2}");
            // 16. feladat
            Console.Write("Add meg a vízszintes hajítás kezdősebességét: ");
            double v0 =double.Parse(Console.ReadLine());
            Console.Write("Add meg az időt másodpercben: ");
            double vt = double.Parse(Console.ReadLine());
            Console.WriteLine($"Az origóbol eldobott test pillanatnyi helyének koordinátái: x={v0*vt}, y={g/2*Math.Pow(vt,2)}");
            // 17. feladat
            Console.Write("Add meg a ferde hajítás víszintesen bezárt szögét: ");
            double va = double.Parse(Console.ReadLine());
            Console.Write("Add meg a ferde hajítás kezdő sebességét: ");
            double v02 = double.Parse(Console.ReadLine());
            Console.Write("Add meg az időt másodpercben: ");
            double vt2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Az origóbol eldobott test pillanatnyi helyének koordinátái: x={v02*vt2} y={v02*vt2*Math.Sin(va)-g/2*Math.Pow(vt2,2)}, A pillanatnyi sebességének koordinátái: x={v02 * Math.Cos(a)}, y={v02 * Math.Sin(a) - g * vt2}, Az emelkedés ideje: T={v02*Math.Sin(a)/g}, a hajítás távja Xmax={Math.Pow(v02,2)*Math.Sin(va)*2/g} az emelkedés max értéke ymax= {Math.Pow(v02,2)*Math.Pow(Math.Sin(a),2)/2*g}");
            



            Console.WriteLine("Nyomd le az entert");
            Console.ReadLine();
        }
    }
}
