using OCP.Refactor;

        var productos = new List<BaseInventario>()
        {
            new InventarioAlimento(new Producto("Papas",1, 12.5)),
            new InventarioMedicamento(new Producto("Analgesico", 2, 23.5)),
            new InventarioAlimento(new Producto("Tomate", 1, 1.30)),
            new InventarioAlimento(new Producto("Manzana",1, 25)),
            new InventarioMedicamento(new Producto("Antibiotico",2, 89)),
            new InventarioMedicamento(new Producto("Antiacido",2, 2.43)),
        };

        Tienda miTienda = new(productos);

        miTienda.CalcularInventario();
