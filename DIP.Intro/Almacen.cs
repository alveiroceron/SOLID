namespace DIP.Intro
{
    class Almacen
    {
        private List<Producto> inventario;

        //nos vemos forzados a crear la propiedad para que pueda contar el inventario
        //al ser una propiedad de tipo List forzamos al auditor a trabajar con List
        public List<Producto> Inventario { get => inventario; set => inventario = value; }

        public Almacen()
        {
            inventario = new List<Producto>();
        }

        public void AdicionarProducto(Producto pProducto)
        { 
            inventario.Add(pProducto);
            Console.WriteLine($"Adicionamos {pProducto.Nombre}");
        }
    }

}
