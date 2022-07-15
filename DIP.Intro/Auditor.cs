namespace DIP.Intro
{
    //clase alto nivel
    class Auditor
    {
        Almacen miAlmacen = new Almacen();

        //Estan fuertemente tipados, auditor solo puede trabajar con objetos de tipo almacen
        public Auditor(Almacen pAlmacen)
        {
            miAlmacen = pAlmacen;
        }

        public double TotalesAlimentos()
        {
            double total = 0;

            foreach (var p in miAlmacen.Inventario)
            {
                if (p.Tipo == 0)
                {
                    Console.WriteLine(p);
                    total += p.Costo;
                }  
            }
            return total;
        }

    }

}
