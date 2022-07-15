using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Intro
{
    public class Empleado
    {
        private string nombre;
        private string puesto;
        private int edad;
        private double sueldo;

        public Empleado(string pNombre, string pPuesto, int pEdad, double pSueldo)
        {
          nombre = pNombre;
          puesto = pPuesto;
          edad = pEdad;
          sueldo = pSueldo;
        }


        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", nombre, puesto, edad, sueldo);
        }

        //aqui van otros metodos relacionados con empleado tales como:
        //asignarHorario
        //proyecto]actual

        //algho que no es responsabilidad del empleado
        //tenemos Dos razones para cambiar la clase
        //cuando cambia algo del empleado y cuando cambia algo relacionado con impuestos

        public double CalcularImpuesto()
        {
            return sueldo * 0.35;
        }

        public void PagarImpuesto()
        {
            double imp = CalcularImpuesto();

            Console.WriteLine($"se pagó{imp} en impuestos por parte de {nombre} ");
        }
    }
}
