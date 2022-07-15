
using DIP.Intro;

Almacen mialmacen = new Almacen();
double total = 0;

mialmacen.AdicionarProducto(new Producto("Tomate", 0, 15.50));
mialmacen.AdicionarProducto(new Producto("Banana", 0, 30));
mialmacen.AdicionarProducto(new Producto("Analgesico", 1, 23.80));
mialmacen.AdicionarProducto(new Producto("Jeans", 2, 450.99));
mialmacen.AdicionarProducto(new Producto("Manzana", 0, 12.38));
mialmacen.AdicionarProducto(new Producto("Antiacido", 1, 38.50));
mialmacen.AdicionarProducto(new Producto("Blusa", 2, 200.88));

Console.WriteLine("*************");

Auditor miauditor = new Auditor(mialmacen);
total = miauditor.TotalesAlimentos();

Console.WriteLine($"El total de alimentos es {total}");
