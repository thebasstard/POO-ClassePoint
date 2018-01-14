using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ClassePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, o, n;
            Point p = new Point();//L'instanciation d'un objet Point
            Console.Out.Write("Donner l'abscisse: ");
            a = double.Parse(Console.In.ReadLine());
            Console.Out.Write("Donner l'ordonne: ");
            o = double.Parse(Console.In.ReadLine());
            //l'appel des méthodes sur l'objet p
            p.setAbscisse(a);
            p.setOrdonne(o);
            n = p.Norme();
            Console.Out.WriteLine("La norme du point (" + p.getAbscisse() + "," + p.getOrdonne() + ") est: " + n);
            Console.ReadKey();
            
        }
    }
}
