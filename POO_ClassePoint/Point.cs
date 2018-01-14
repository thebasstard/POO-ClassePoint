using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ClassePoint
{
    class Point
    {
        private double Abscisse;            //L'attribut Abscisse
        private double Ordonne;             //L'attribut Ordonne

        public double getAbscisse()         //Le getter de l'attribut Abscisse
        {
            return Abscisse;
        }

        public void setAbscisse(double a)   //Le setter de l'attribut Abscisse
        {
            Abscisse = a;
        }

        public double getOrdonne()          //Le getter de l'attribut Ordonne
        {
            return Ordonne;
        }

        public void setOrdonne(double o)    //Le setter de l'attribut Ordonne
        {
            Ordonne = o;
        }

        public Point()                     //Le constructeur par défaut
        {
        }

        public Point(double a, double o)   //Le constructeur d'initialisation
        {
            Abscisse = a;
            Ordonne = o;
        }

        public double Norme()              //La méthode Norme
        {
            return Math.Sqrt(Abscisse * Abscisse + Ordonne * Ordonne);
        }
    
    }
}
