namespace OCP.Intro
{
    class Producto
    {
        private string nombre;
        private int categoria;
        private double precio;

        //with expression body definition
        public string Nombre{ get => nombre; set => nombre = value;}

        //with backing fields
        public int Categoria 
        {
            get { return categoria; }
            set { categoria = value; }

        }
        public double Precio { get => precio; set => precio = value; }


        public Producto(string pNombre, int pCategoria, double pPrecio)
        {
            nombre = pNombre;
            categoria = pCategoria; 
            precio = pPrecio;   
        }

        public override string ToString()
        {
            return string.Format("El producto {0} cuesta {1}", nombre, precio);
        }

    }
}
