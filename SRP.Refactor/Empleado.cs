using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Refactor
{
    //Hacemos refactor de empleado para dejarla solamente con una responsabilidad
    public class Empleado
    {
        private string nombre;
        private string puesto;
        private int edad;
        private double sueldo;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }


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

        //solo metodos responsabilidad de empleado
        //asignarHorario
        //proyecto]actual

    }
}
