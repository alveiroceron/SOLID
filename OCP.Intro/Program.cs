//crear mecanimos para extender la clase y no modificarla (Ejemplo:variables de referencia, polimorfismo)
//debemos crear codigo que no necesite ser modificado cada que hay cambios en los requerimientos

//beneficios:
//reducir bugs al disminuir cantidad de cmabios
//se reducen los test de lo nuevo y no toda la clase

using OCP.Intro;

        var productos = new List<Producto>()
        {
            new Producto("Papas",1, 12.5),
            new Producto("Analgesico", 2, 23.5),
            new Producto("Tomate", 1, 1.30),
            new Producto("Manzana",1, 25),
            new Producto("Antibiotico",2, 89),
            new Producto("Antiacido",2, 2.43),
        };

        var tienda = new Tienda(productos);
        tienda.CalcularInventario();

