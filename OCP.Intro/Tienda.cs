namespace OCP.Intro
{
    class Tienda
    {
        private List<Producto> products;

        public Tienda(List<Producto> pProductos)
        {
            products = pProductos;
        }

        public void CalcularInventario()
        {
            double total = 0;

            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //    total += product.Precio;
            //}

            //cambio
            foreach (var product in products)
            {
                if (product.Categoria == 1)
                {
                    //alimentos aplica el 20% de dcto
                    Console.ForegroundColor = ConsoleColor.Green;
                    product.Precio *= 0.8;
                    Console.WriteLine(product);
                    total += product.Precio;

                }

                if (product.Categoria == 2)
                {
                    //incrementa el 20%
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    product.Precio *= 1.2;
                    Console.WriteLine(product);
                    total += product.Precio;
                }
          
            }

            Console.WriteLine($"Total del inventario es {total}");
        }
    }
}
