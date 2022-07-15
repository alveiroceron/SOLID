namespace OCP.Refactor
{
    class Tienda
    {
        private List<BaseInventario> products;

        public Tienda(List<BaseInventario> pProductos)
        {
            products = pProductos;
        }

        public void CalcularInventario()
        {
            double total = 0;

            foreach (var product in products)
            {
                product.CalcularProducto();
                Console.WriteLine(product);
                total += product.Producto.Precio;
            }

            Console.WriteLine($"Total del inventario es {total}");
        }
    }
}
