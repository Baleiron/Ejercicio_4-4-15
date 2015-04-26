using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4_4_15
{
    public class Persona15
    {
        public Persona15(int altura, int peso, string colorOjos, string colorPelo)
        {
            this.altura15 = altura;
            this.colorOjos15 = colorOjos;
            this.colorPelo15 = colorPelo;
            this.peso15 = peso;
        }

        public int peso15;
        public int altura15;
        public string colorOjos15;
        public string colorPelo15;

        private bool lentillaValida;
        private bool pesoValido;
        
        public void PonerLentillas15(string colorLentillas)
        {
            lentillaValida = false;
            lentillaValida = ComprobarColor15(colorLentillas);

            if (lentillaValida)
            {
                this.colorOjos15 = colorLentillas;
            }
        }

        public void Engordar15(int cantidad)
        {
            double novoPeso = this.peso15 + cantidad;
            pesoValido = ComprobarPeso15(novoPeso);

            if (!pesoValido || cantidad < 0)
            {
                Console.WriteLine("Cantidade incorrecta");
            }
            else
            {
                Console.WriteLine("Cambiando o peso en {0} kg", cantidad);
                this.peso15 = (int)novoPeso;
            }
        }

        public void Adelgazar15(double cantidad)
        {
            double novoPeso = this.peso15 - cantidad;
            pesoValido = ComprobarPeso15(novoPeso);

            if (!pesoValido || cantidad < 0)
            {
                Console.WriteLine("Cantidade incorrecta");
            }
            else
            {
                Console.WriteLine("Cambiando o peso en {0} kg", cantidad);
                this.peso15 = (int)novoPeso;
            }
        }

        private bool ComprobarColor15(string color)
        {
            if (color.Equals("azul") || color.Equals("marrón") || color.Equals("verde"))
            {
                lentillaValida = true;
            }
            return lentillaValida;
        }

        private bool ComprobarPeso15(double novoPeso)
        {
            if (novoPeso < 40 || novoPeso > 180)
            {
                pesoValido = false;
            }
            else
            {
                pesoValido = true;
            }
            return pesoValido;
        }
    }
}
