﻿namespace DIP.Intro
{
    public class Producto
    {
        private string nombre;
        private int tipo;   //0 Alimento, 1 medicina, 2 Ropa
        private double costo;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public double Costo
        {
            get { return costo; }
            set { costo = value; }            
        }

        public Producto(string pNombre, int pTipo, double pCosto)
        {
            nombre = pNombre;
            tipo = pTipo;
            costo = pCosto;
        }

        public override string ToString()
        {
            string strTipo = "";

            if (tipo == 0)
                strTipo = "Alimento";
            else if (tipo == 1)
                strTipo = "Medicina";
            else if (tipo == 2)
                strTipo = "Ropa";

            return string.Format("{0}, tipo {1}, costo ${2}", nombre, strTipo, costo);
        }
    }
}
