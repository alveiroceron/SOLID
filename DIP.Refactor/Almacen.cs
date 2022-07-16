namespace DIP.Refactor
{
    class Almacen: IAuditable
    {
        //no necesitamos dar acceso publico a la lista
        private readonly List<Producto> inventario;

        public Almacen()
        {
            inventario = new List<Producto>();
        }

        public void AdicionarProducto(Producto pProducto)
        { 
            inventario.Add(pProducto);
            Console.WriteLine($"Adicionamos {pProducto.Nombre}");
        }

        //implementamos la interfaz, hacemnos una busqueda flexible
        public IEnumerable<Producto> ObtenProductos(int pTipo)
        {
            var productList = new List<Producto>();

            foreach (var p in inventario)
            {
                if(p.Tipo == pTipo)
                    productList.Add(p);
            }

            return productList;
        }
    }
}
