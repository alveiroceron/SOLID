﻿//PRINCIPIO DE INVERSION DE DEPENDENCIA: dependencia fuerte entre modulo de alto nivel con uno de bajo nivel
//podemos tener un modulo de alto nivel con un modulo de bajo nivel, si hay un cambio en el de bajo nivel el de alto nivel se afecta
//se busca un desacoplamiento con abstracciones

//los modulo sde alto ybajo nivel deoen depender de las abstracciones



using DIP.Intro;

Almacen mialmacen = new Almacen();
double total = 0;

//0 Alimento, 1 medicina, 2 Ropa
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
